   M S B A M L   `   `   `  ?????  ;WSR6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WSR6.Pages
WSR6.Pages  5          WSR6.Pages.ProductPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:WSR6.Pages     5        N? Title$  ООО «Цветы»??5	      .??5      ? 
??????? ? RowDefinitions 5   
   ?? 5      $??* ?6   6)   ?? 5      $??50 ?6   6*   .+?5   
   ?? $??1??6   $??/Resources/logo.png??6   $??Center=?6:    J? Opacity$	 0.4Q?6W   6g   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DGridProduct??5         AutoGenerateColumns .     
IsReadOnly . $??10,20,10,29q?6W      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 30 6%      Header$ ID??61   	   
FontFamily$	 Comic Sans MS)?6f   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6=   ?? *ProductArticleNumber+6?     5      $
 auto 6%   $ Название??63   $	 Comic Sans MS)?6e   
 6E   ?? *ProductName+6?     5      $
 auto 6%   $ Описание??64   $	 Comic Sans MS)?6m   
 6F   ?? *ProductDescription+6?     5      $
 auto 6%   $ Категория??64   $	 Comic Sans MS)?6k   
 6G   ?? *ProductCategory+6?     5      $
 auto 6&   $  Производитель??64   $	 Comic Sans MS)?6s   
 6K   ?? *ProductManufacturer+6?     5      $
 auto 6%   $" Цена без скидки??63   $	 Comic Sans MS)?6l   
 6L   ?? *ProductCost+6?     5      $
 auto 6%   $ Скидка??63   $	 Comic Sans MS)?6m   
 6C   ?? *ProductDiscountAmount+6?     5      $
 auto 6%   $ Остаток??63   $	 Comic Sans MS)?6o   
 6D   ?? *ProductQuantityInStock+6?   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      ?? 5      .R?5      ?? $	??150??6$   $	??150??60   ??6=   ?? *ProductPhoto+6_   5      5!        5"       5#      ?? 5$      .R?5%      ?? $??BtnEdit??6C   -   5        $??80??5%   %   $??Изменить??60   $??Comic Sans MS)?6h   ???	#FF498C516?   5&      5(      5+      ?? 5,   
   -   5        $??BtnEdit??5,   $   $??Изменить??6   $??1??6I   $	??150??6V   $
??Left=?6b   $??Comic Sans MS)?6}   ???	#FF76E3836?   ?? 5-   
   -   5        $??BtnDel??5-   0   $??Удалить??6   $??1??6#   $	??150??6T   $??Right=?6`   $??Comic Sans MS)?6|   ???	#FF76E3836?   ?? 5.   
   -   5        $??BtnAdd??5.   $   $??Добавить??6   $??1??6H   $	??150??6U   $??Center=?6a   $??Comic Sans MS)?6~   ???	#FF76E3836?   50      51      