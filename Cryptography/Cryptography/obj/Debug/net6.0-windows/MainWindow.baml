   M S B A M L   `   `   `  ����G  CCryptography, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:CryptographyCryptography  5   	       Cryptography.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Cryptography     5   	     � Title$	  App��5   	   $	��700��6   $	��800��6"   .��5	      � $��5q�6    � RowDefinitions 5
   
   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��100px �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6!   
�������$��	3 3 0.5 3q�6F   �� 5   
   $��1��6   $��0��6!   
�������$��	0.5 3 3 3q�6F    � 5   
   -   5          �Name$ 	MainFrame��5   5   $��
0.5 ,3,3,3q�6   $��1��6%   $��Stretch=�6I   $��Center=�6e   $��Stretch=�6�   $��Center=�6�     � Source$ Pages/Lab1.xaml?�6�     � NavigationUIVisibility$ Hidden=�6�   �� 5   
   -   5        $��StackPanelNav��5   9   $��10q�6    �� Orientation$ Vertical=�6"   .+�5         Cryptography.NavButton     Cryptography.NavButton   Click$ NavButton_Click��6C      Text$
 Lab1��6   	   NavUri$	 Pages/Lab1.xaml?�6*   6C     5      $ NavButton_Click��6C   $
 Lab3��6   $	 Pages/Lab3.xaml?�6*   6C   5      5      5      