   M S B A M L   `   `   `  ����M  Isession14-projects, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:session14_projectssession14_projects  5   	   )    #session14_projects.GridViewExample2   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:session14_projects     5   	     � Title$  GridViewExample2��5   	   $	��300��6"   $	��600��6/   .��5	      � .+�5   
   �� -   5         ��Name$ 	lvAuthors��5      $��10q�6   
�������$
��Bold"�6E    � 	Resources 5       �� 
TargetType �� Property �� Value��%Z   '��       �� 5      " ��6   .�5      ��  � ��$ Right=�6C   6S   5      5       �� View 5      �� 5       �� AllowsColumnReorder .   �� ColumnHeaderToolTip$ Authors��67   -   5        	gVAuthors��	 �� ColumnHeaderContextMenu	 5      �� 5      .@�5      m� -   5        $��	Ascending��5   '   6S   m� 5      $��
Descending��6'   6=   5      .P�5      �� $
��Name��6%   
 �� Width$	
 120��63    �� DisplayMemberBinding 6?   �� *Name+�� 5      $	��Age��6%   $
 40��62    6=   �� *Age+�� 5      $
��Book��6%   $	
 200��63    �� CellTemplate 5      �� 5      .R�5   "   �� $��Italic$�5   ,   
���  ����5   ,   �� *Book+5!   #   5"      5$      �� 5%      $	��MVP��6%   $
 40��62    6=   �� *MVP+5&      5(      5)      5*      