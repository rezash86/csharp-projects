   M S B A M L   `   `   `  ����M  Isession14-projects, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:session14_projectssession14_projects  5   	   +    %session14_projects.DataGridRowExample   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:session14_projects     5   	     � Title$  DataGridRowExample��5   	   $	��300��6$   $	��400��61   .��5	      � $��10q�6   .+�5
   
   �� $!��./images/homer-simpson.jpeg��6   67   &   System.Windows.Controls.DataGrid  5   
   -   5        $��	dGAuthors��5         AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Name+6N     5      $ 
Birth date��6%    69   �� *
Birthday+6X      RowDetailsTemplate 5      �� 5      .R�5      ]� 
�������.+�5      �� $
��Left=�6    $��60��6R   $��10��6^   ��66   �� *
ImageUrl+6^   � 5      $
��0,10q�6    � ColumnDefinitions 5      �� 5   "   $
��Auto �63   �� 5   "   $��* �63    � RowDefinitions 5      �� 5   "   $
��Auto �60   �� 5   "   $
��Auto �60   �� 5   "   $
��Auto �60   .+�5       �� $��ID : ��6(   $
��Bold"�65   �� 5!      $
��Bold"�6<   $��1��6N   ��6(   �� *Id+6N   �� 5"      $��Name : ��6(   $
��Bold"�67   $��1��6I   $��0��6V   �� 5#      $
��Bold"�6>   $��1��6P   $��1��6]   ��6(   �� *Name+6]   �� 5$      $��Birthday : ��6(   $
��Bold"�6;   $��2��6M   $��0��6Z   �� 5%      $
��Bold"�6R   $��2��6d   $��2��6q   ��6(   �� *
Birthday+ �� StringFormat$ d��6q   5&      5'      5(      5*      5+      5,      