# Petri-Dish 说明书

## 1 开始使用

### 1.1 设置项目路径

在使用PD时你首先需要指定Cellwar.Game的根目录。**（注：是clone下来后文件夹的根目录）**

```
Settings -> Set Project Directory
```

设置完成后需要按OK才会保存。

### 1.2 快捷启动

```
Open Project... -> Scene 
```

快速打开场景。

```
Open Project... -> Folder 
```

使用资源管理器打开项目某处文件夹的快捷方法。常用的为根目录与Asset。

```
Open Project... -> Github Page 
```

快速打开Cellwar.Game的Github页面。

```
Open Project... -> with Powershell
```

快速用Powershell打开项目目录。

## 2 开始编辑数据

## 2.1 编辑Json

### 2.1.1 打开Json文件

```
Edit -> Resources
```

选择你希望编辑的数据文件。**（注：文件不能为空，至少需要最基本的json元素如"{}"或"[]"文本）**

### 2.1.2 使用json编辑器

#### 2.1.2.1 复制一个json实例的方法

例如你希望添加一个strain，则你先需要复制之前已经有的strain实例。

~~~
[鼠标右击某一个Array下的某一个已有对象] -> Edit -> Copy
[鼠标右击某一个Array下的某一个已有对象] -> Edit -> Paste Node Before 或 Paste Node After
~~~

你就会获得一个完全相同的对象。

#### 2.1.2.2 修改某个对象的数据

```
[展开某个值至最底层] -> [在右边的Json Value框中修改值]
```

**（注：不要去掉了双引号）**

#### 2.1.2.3 保存

```
File -> Save
Or
[ Ctrl + S ]
```

改进后的程序将在每次尝试退出时询问是否保存（即使不进行任何改动）。