﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using CellWar.Model.Json;
using CellWar.Model.Substance;
using CellWar.Utils;
using CellWar.Utils.Object;
using PetriDish.App;
using static CellWar.Model.Substance.Strain;


namespace CellWar.GameData {
    /// <summary>
    /// 游戏本地数据
    /// </summary>
    public static class Local {
        /// <summary>
        /// 加载所有的race
        /// geneNameList的规范为 r1;c1;c2;r2;c3;r3;c4
        /// reg后的cod会被自动归类到该r的支配基因中，读到下一个reg时停止
        /// r1;c1;c2;r2;c3;r3;c4
        /// 将会转化为
        /// r1 - c1
        ///      c2
        ///      
        /// r2 - c3
        /// 
        /// r3 - c4
        /// </summary>
        /// <returns></returns>
        public static List<Race> LoadAllRaces() {
            var allRaceJson = CellWar.Utils.JsonHelper.Json2Object_NT<List<RaceJsonModel>>( GetGameDataPath( "race.json" ) );
            AllRaces = new List<Race>();
            foreach( var raceJson in allRaceJson ) {
                if( raceJson.CodingGeneNames == "" ) continue;

                var geneNameList = raceJson.CodingGeneNames.Split( ';' );
                List<RegulatoryGene> regulatoryGenes = new List<RegulatoryGene>();

                RegulatoryGene previousReg = null;

                foreach( var geneName in geneNameList ) {
                    var regGene = AllRegulartoryGenes.Find( m => m.Name == geneName );
                    // 首个名字必须为 reg gene
                    if( regGene == null && previousReg == null ) {
                        throw new InvalidOperationException( "Invalid GeneNames. you should input a reg gene at first of the string list"
                            + "\n current gene name:" + geneName );
                    } else if( regGene == null && previousReg != null ) {
                        // 继续增加该reg下的支配cod 
                        var codGene = AllCodingGenes.Find( m => m.Name == geneName );
                        if( codGene != null ) {
                            previousReg.DominatedGenes.Add( codGene );
                        } else {
                            throw new InvalidOperationException( "No gene named: " + geneName + "\n you should call LoadAllRaces() after LoadAllCodingGenes" );
                        }
                    } else if( regGene != null ) {
                        // 开始添加下一个reg
                        previousReg = ObjectHelper.Clone( regGene, regGene.GetType() );
                        regulatoryGenes.Add( previousReg );
                    }
                }
                AllRaces.Add( new Race {
                    Name = raceJson.Name,
                    MaxLength = raceJson.MaxLength,
                    RegulatoryGenes = regulatoryGenes
                } );
            }
            return AllRaces;
        }
        public static List<Race> AllRaces { get; set; }

        public static List<CodingGene> LoadAllCodingGenes() {
            Local.AllCodingGenes = CellWar.Utils.JsonHelper.Json2Object_NT<List<CodingGene>>( GetGameDataPath( "coding_gene.json" ) );
            return AllCodingGenes;
        }
        public static List<CodingGene> AllCodingGenes { get; set; }

        public static List<Chemical> LoadAllChemicals() {
            Local.AllChemicals = CellWar.Utils.JsonHelper.Json2Object_NT<List<Chemical>>( GetGameDataPath( "chemicals.json" ) );
            return AllChemicals;
        }

        public static List<RegulatoryGene> LoadAllRegulartoryGenes() {
            var allRegulatoryGeneJson = CellWar.Utils.JsonHelper.Json2Object_NT<List<RegulartoryGeneJsonModel>>( GetGameDataPath( "reg_gene.json" ) );
            List<RegulatoryGene> regulatoryGenes = new List<RegulatoryGene>();
            foreach( var geneJson in allRegulatoryGeneJson ) {
                RegulatoryGene gene = new RegulatoryGene();
                gene.Type = geneJson.Type;
                gene.Name = geneJson.Name;
                gene.Description = geneJson.Description;
                gene.Length = geneJson.Length;

                foreach( var cc in geneJson.Condition ) {
                    var ch = ObjectHelper.Clone( FindChemicalByName( cc.Chemical ) );
                    if( ch != null ) {
                        ch.Count = cc.Count;
                        gene.Conditions.Add( ch );
                    }
                }

                regulatoryGenes.Add( gene );
            }
            AllRegulartoryGenes = regulatoryGenes;
            return regulatoryGenes;
        }

        public static Chemical FindChemicalByName( string chemicalName ) => AllChemicals.Find( c => { return c.Name == chemicalName; } );

        public static List<RegulatoryGene> AllRegulartoryGenes { get; set; }
        public static List<Chemical> AllChemicals { get; set; }

        public static string GetGameDataPath( string fileName ) => Path.Combine( ProjectDirectoryHelper.ProjectDir.Basic, "CellWar.Game/Assets/Resources/GameData/" + fileName );

        public static string Readable( string name, string description ) {
            return string.Format( "Name:{0}\nDescription:{1}", name, description );
        }
    }

    /// <summary>
    /// 玩家储存数据
    /// TODO：玩家信息
    /// </summary>
    public static class Save {
        public static List<Strain> Strains = new List<Strain>();
        public static string GetGameSavePath( string fileName ) => Path.Combine( ProjectDirectoryHelper.ProjectDir.Basic, "CellWar.Game/Assets/Resources/Save/" + fileName );
        public static void SaveAllStrains() {
            File.WriteAllText( Save.GetGameSavePath( "strains.json" ), JsonHelper.Object2Json( Save.Strains ) );
        }

        public static List<Strain> LoadAllStrains() {
            Strains = JsonHelper.Json2Object_NT<List<Strain>>( GetGameSavePath( "strains.json" ) );
            return Strains;
        }

    }
}
