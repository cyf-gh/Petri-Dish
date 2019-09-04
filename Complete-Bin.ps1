$x = Split-Path -Parent $MyInvocation.MyCommand.Definition

Copy-Item $x\\.bin_asset\\data $x\\PetriDish\\PetriDish.App\\bin\\Debug -Recurse -Force
Copy-Item $x\\.bin_asset\\data $x\\PetriDish\\PetriDish.App\\bin\\Release -Recurse -Force

Write-Host("Done")