   M S B A M L   `   `   `  ����B  >WpfApp6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApp6.WindowsWpfApp6.Windows  5   	   #    WpfApp6.Windows.ComplexWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApp6.Windows     5   	     � WindowState$  	Maximized=�5   	   $	��450��6!   $	��800��6.   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��174* �6   �� 5      $	��43* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   ��5   
   �� 5       �� ImageSource$; 5/Res/1614759722_58-p-abstraktsii-na-belom-fone-77.png��6   .+�5   
    � -   5          �Name$ frDisciplite��5        � NavigationUIVisibility$ Hidden=�5      $��0��5       � 5   
   -   5        $ 	frTeacher��5      $ Hidden=�5      $��1��5      �� 5!   
   -   5        $��1��5!      $��1��5"      $��60��5#      $	��300��5$      $	��Top=�5%      $
��Left=�5&      $��50 0 0 0q�5'      
��� ���
����  �$��25(�5*      $,��&Добавить в ведомость��5+      60   �� 50   
   $��1��6   $
��Left=�51      $��1��53      .+�54      �� -   5         ��Name$ btnClearDescipline��55      $��35��54      
������ $	��↪��57      $��20(�58      
��� ���$��35��5:      6    �� 5;      -   5        $ btnClearTeacher��5<      $��35��5;      
������ $	��↪��5>      $��20(�5?      
��� ���$��35��5A   	   6   5B      �� 5D   
   $��0��6   $��Right=�5E      $��0 0 10 0q�5F      $��1��5G      ._�5H      �� .+�5I      �� 
�������$��1q�5J      ._�5K      �� -   5         ��Name$ lblDiscipline��5K       $��3q�5L       $0��*Дисциплина не выбранна��5M      $
��Wrap=�5N      
������ 
����  �$��20(�5Q      5S      �� 5T      
�������$��1q�5U      ._�5V      �� -   5        $ 
lblTeacher��5V       $(��"Учитель не выбранн��5W      $��NoWrap=�5X      $��3q�5Y       
������ 
����  �$��20(�5\      5^      5`      5a      5b      5c      