   M S B A M L   `   `   `  ����B  >WpfApp6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApp6.WindowsWpfApp6.Windows  5   	        WpfApp6.Windows.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApp6.Windows     5   	     � Title$  
MainWindow��5   	    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowState$ 	Maximized=�5
   	   $
��1080��5   	   $
��1920��6   .��5      � ��5   
   �� 5       �� ImageSource$; 5/Res/1614759722_58-p-abstraktsii-na-belom-fone-77.png��6    � ColumnDefinitions 5   
   �� 5      $
��100* �6   �� 5      $
��241* �6   �� 5      $	��59* �6   .+�5   
   ��  �� CornerRadius$ 30��6   $��3q�6#    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      ��5      �� 5       �� EndPoint$ 1,-1.1&�6&    �� 
StartPoint$ 1,0.6&�68   .��5      � 	 � Color$	 	#FF00001F��6#   � 5      $	 	#FF3333FF��6#   
 � Offset$
 1Q�5   #   5      ._�5!      �� $��Center=�6   $	��Top=�66   .+�5"      �� $��\Res\photo.png��6   $��100 40 100 100q�60   �� 5#      -   5         ��Name$ 	BtnGroupe��5$         ButtonStyleWhiteRight#���   5#      $��ГРУППЫ��5%      5&      �� 5'      -   5        $ 
BtnStudent��5'      $��СТУДЕНТЫ��5(      #���   5)      5*      �� 5+      -   5        $ 
BtnTeacher��5+      $ ��ПРЕПОДАВАТЕЛИ��5,      #���   5-      5.      �� 5/      -   5        $ 	BtnThriph��5/      $��ДИСЦИПЛИНЫ��50      #���   51      52      �� 53      -   5        $ BtnVedomost��53      $��ВЕДОМОСТЬ��54      #���   55      6E   58      59       � 5:   
   -   5          �Name$	 Fra��5:      $��1��6   $��40,10,26,10q�5;        � NavigationUIVisibility$ Hidden=�5<      �� 5?   
   
���   �
�������$��1q�5A      $��5q�5B      $��Center=�6(   $��Center=�6E   $��2��6`   ._�5C      � .+�5D      �� .+�5F      �� -   5         ��Name$ TbGroup��5F       $��12(�5G   (   $
��Bold"�5H   (   $��5q�5I   (   $
��Wrap=�5J   (   �� 5L      -   5        $ 
TbFullName��5L       $��12(�5M   (   $
��Bold"�5N   (   $��5q�5O   (   �� 5Q      -	   5        $ TbDiscipline��5Q       $��12(�5R   (   $
��Bold"�5S   (   $��5q�5T   (   $
��Wrap=�5U   (   5W      5X      5Y      5Z      5[      