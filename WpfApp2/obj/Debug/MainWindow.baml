   M S B A M L   `   `   `  ????B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	       WpfApp2.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5
      ? ??5   
   ?? 5       ?? ImageSource$$ /photomode_21122020_191211.png??6    ? RowDefinitions 5   
   ?? 5      $	??20* ?6   ?? 5      $
??160* ?6   ?? 5      $	??20* ?6    ? ColumnDefinitions 5   
   ?? 5      $	??40* ?6   ?? 5      $	??60* ?6   ?? 5      $	??40* ?6   .+?5   
   ?? -   5        $??0??5      $??Удалить??6!   $??	10,0,0,10q?63   $??2??6F   $??20??6S   $??Bottom=?6_   6z   ?? 5   
   -   5        $??2??5      $??Создать??6!   $??2??63   $??	0,0,10,10q?6@   $??20??6S   $??Bottom=?6_   6z   ?? 5   
   -   5         ??Name$ Noteswindow??5      $??0,0,0,0q?6'   $??1??68   $??1??6E   ??6u   Z? (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dateContainer??5      $??
10,10,10,5q?6,   $??3??6@      FirstDayOfWeek$ Monday=?6T      SelectedDateFormat$ Short=?6l   ?? 5   
   $??2??6   $??20,150,10,0q?6$   $??1??69   $
??Wrap=?6F   $%??Название заметки??6Z   $	??Top=?6r    ?? TextAlignment$ Center=?6?   $??16??6?   ?? 5   
   $??2??6   $??
20,13,10,0q?6$   $??1??68   $
??Wrap=?6E   $%??Описание заметки??6Y   $	??Top=?6q   $ Center=?6?   $??16??6?   ?? 5   
   -   5        	 ??Name$	 NAMEBox??5      $??2??6#   $??
10,195,9,0q?63   $??1??6G   
 ?? TextWrapping$

 Wrap=?6T   $?? ??6h   $	??Top=?6p   $??18??6?   ?? 5   
   -   5        $	 DescrBox??5      $??2??6$   $??
15,45,14,0q?64   $??1??6H   $

 Wrap=?6U   $?? ??6i   $	??Top=?6q   $??18??6?   5       5!      