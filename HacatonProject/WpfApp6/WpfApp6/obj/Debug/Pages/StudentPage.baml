   M S B A M L   `   `   `  ����B  >WpfApp6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp6.PagesWpfApp6.Pages  5          WpfApp6.Pages.StudentPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WpfApp6.Pages     5        N� Title$  StudentPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��100* �6   �� 5      $
��400* �6   .+�5   
   �� 
���   �$��1q�5      $��30��5       �� CornerRadius$ 10��5       �� Padding$ 10 0 0 0q�5      $��
40 0 40 40q�5      $��Bottom=�5      
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      ._�5      �� -   5         ��Name$ tbSearch��5      
������ $��10 0 0 0q�5      $��Center=�5       $��0q�5"      5#      5%      �� 5&   
   $%��Список студентов��6   $��Bottom=�5'      $
��Left=�5(      $��10q�5)      $��2��5*      $��Arial)�5+      $��20(�5,      �� 5.   
   
�������$��1��5/      $��2��50      $��Bottom=�51      $��	7 0 40 10q�52      &   System.Windows.Controls.DataGrid  55   
   -   5          Name$ dg��55      $��0 0 0 40q�6   $��1��56      $��0��58         AutoGenerateColumns .  
������    DGStyle#��[  5>        DataGridCell   	CellStyle# [ 5?        ColumnHeaderStyle	   ColumnHeaderStyle#	 [ 5@      
   GridLinesVisibility$
 
Horizontal=�5A         HorizontalGridLinesBrush
 �����   Columns 5D      0  *System.Windows.Controls.DataGridTextColumn  5E      ,  &System.Windows.Controls.DataGridColumn   Header$ Группа��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *GroupeString+   ElementStyle 5F      �� 5G      .�5H      ��  �� Property � �� �� Value$
 Wrap=�6G   �� 5I       �@��TextAlignment$
 Left=�6H   5J      5L        5M      $ Подгруппа��6%    68   �� *UnderGroupe+ 5N      �� 5O      .�5P      ��  � ��$
 Wrap=�6G   �� 5Q       �@��TextAlignment$
 Left=�6H   5R      5T        5U      $  Специальность��6%    6<   �� *Specialtity+ 5V      �� 5W      .�5X      ��  � ��$
 Wrap=�6G   �� 5Y       �@��TextAlignment$
 Left=�6H   5Z      5\        5]      $ Куратор��6%    66   �� *	Kurator+ 5^      �� 5_      .�5`      ��  � ��$
 Wrap=�6G   �� 5a       �@��TextAlignment$
 Left=�6H   5b      5d        5e      $ Б/ВБ��6%    63   �� *Budget+ 5f      �� 5g      .�5h      ��  � ��$
 Wrap=�6G   �� 5i       �@��TextAlignment$
 Left=�6H   5j      5l        5m      $ ФИО��6%    62   �� *
FullName+ 5n      �� 5o      .�5p      ��  � ��$
 Wrap=�6G   �� 5q       �@��TextAlignment$
 Left=�6H   5r      5t        5u      $* $Приказ о зачислении��6%    6B   �� *OrderOfEnrollment+  5v      $3 -Приказ об академ.отпуске��6%    6G   �� *TheOrderOfTheAcademyVacation+  5w      $ Причина а/о��6%    6:   �� *ReasonVacation+  5x      $5 /Дата выхода из ак. отпуска��6%    6I   �� * ExitDateFromTheAcademyVacation+  5y      $0 *Приказ о восстановлени��6%    6E   �� *RestorationOrder+  5z      $, &Приказ об отчислении��6%    6C   �� *OrderOfExpulsion+  5{      $ Причина��6%    66   �� *ReasonExpulsion+  5|      $ М/Ж��6%    62   �� *Gender+  5}      $, &Регистрация в Москве��6%    6C   �� *RegistrationInMoscow+  5~      $ Дата рождения��6%    6<   �� *
Birthday+  5      $' !Мобильный телефон��6%    6@   �� *Phone+  5�      $< 6ФИО матери, мобильный телефон��6%    6L   �� *MothersFullNameMobilePhone+  5�      $8 2ФИО отца, мобильный телефон��6%    6J   �� *PhathersFullNameMobilePhone+  5�      $% Домашний телефон��6%    6?   �� *	HomePhone+  5�      $> 8Адрес фактического проживания��6%    6L   �� *AddressOfActualResidence+  5�      $' !Адрес регистрации��6%    6@   �� *AddressOfRegistration+  5�      $' !Паспортные данные��6%    6@   �� *PassportData+  5�      $7 1МЕД ПОЛИС (номер, кем выдан)��6%    6K   �� *!MedicalPolicyNumberIssuedByWhom+  5�      $ 
СНИЛС��6%    64   �� *SNILS+  5�      $ ИНН��6%    62   �� *INN+  5�      $! Почтовый адрес��6%    6=   �� *PostalAddress+  5�      $ Компетенция��6%    6:   �� *
Competence+  5�      $$ Прививка от Covid-19��6%    6C   �� *VaccinationAgainstCovid19+  5�      $% Руководитель ВКР��6%    6?   �� *HeadOfTheWRC+5�      �� 5�   
   -   5         ��Name$ BtnDel��5�      
��� ���
�������$��Удалить��5�      $��Right=�5�      $��Bottom=�5�      5�      5�      