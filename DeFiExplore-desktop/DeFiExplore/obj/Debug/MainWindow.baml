   M S B A M L   `   `   `  ����F  BDeFiExplore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:DeFiExploreDeFiExplore  5   	       DeFiExplore.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:DeFiExplore     5   	     � Title$  
MainWindow��5   	   $	��780��6   $	��800��6)    � 
ResizeMode$ NoResize=�65   .��5	      �  � RowDefinitions 5
   
   �� 5      $��40 �6   �� 5      $	��200 �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $	��400 �6   �� 5      $	��400 �6   .+�5   
   �� $��0��6   $��0��6    $��25(�60   .@�5      ��  �� 
IsSelected . .��6-   
BTC/USDT67   �� 5      .��6   
ETH/USDT6%   �� 5      .��6   
ADA/USDT6%   �� 5      .��6   	DOGE/USDT6&   5      �� 5   
   -   5         ��Name$ btnShow��5      $��1��6"   $��0��62   $��Prikazi��6U   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 130 6%   $��1��67   $��2��6D   �� 5   
   -   5         ��Name$ stkPanel��5      $��2��6'   $��2��64   	 �� Orientation$	 Vertical=�6H   5      5      