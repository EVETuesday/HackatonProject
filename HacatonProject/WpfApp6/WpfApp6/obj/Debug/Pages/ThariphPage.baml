   M S B A M L   `   `   `  ����B  >WpfApp6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp6.PagesWpfApp6.Pages  5          WpfApp6.Pages.ThariphPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WpfApp6.Pages     5        N� Title$  ThariphPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��100* �6   �� 5      $
��400* �6   .+�5   
   �� 
���   �$��1q�5      $��30��5       �� CornerRadius$ 10��5       �� Padding$ 10 0 0 0q�5      $��
40 0 40 40q�5      $��Bottom=�5      
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      ._�5      �� -   5         ��Name$ tbSearch��5      
������ $��10 0 0 0q�5      $��Center=�5       $��0q�5#      5%      �� 5&   
   $%��Список дисциплин��6   $��Bottom=�5'      $
��Left=�5(      $��10q�5)      $��2��5*      $��Arial)�5+      $��20(�5,   	   �� 5.   
   
�������$��1��5/      $��2��50      $��Bottom=�51      $��	7 0 40 10q�52      &   System.Windows.Controls.DataGrid  55   
   -   5          Name$ dg��55      $��0 0 0 40q�6   $��0��56      $��1��57      
������    DGStyle#��[  5;        DataGridCell   	CellStyle# [ 5<        ColumnHeaderStyle   ColumnHeaderStyle# [ 5=      	   GridLinesVisibility$	 
Horizontal=�5>      
   HorizontalGridLinesBrush

 �����5?      5F      5G      