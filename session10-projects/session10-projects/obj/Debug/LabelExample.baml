   M S B A M L   `   `   `  ����M  Isession10-projects, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:session10_projectssession10_projects  5   	   %    session10_projects.LabelExample   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:session10_projects     5   	     � Title$  LabelExample��5   	   $	��350��6   $	��500��6+   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $
��160* �6   �� 5      $
��300* �6   .+�5   
   �� -   5         ��Name$ lblFirstName��5      $��Employee _First Name:��6&   $��Right=�6r   $��Center=�5      $��1��6+    �� Target 5   F   ��  �� ElementName$ txtFirstName��5   :   �� 5   
   -   5        $ lblLastName��5      $��Right=�6Q   $��Center=�5      $��2��6+    5   &   �� $ txtLastName��.��5   8   Employee _Last Name:6N   �� 5   
   -   5         ��Name$ txtFirstName��5      $
��Left=�6(   $��23��6C   $	��120��5      $��1��6   $��1��6+   6=   �� 5   
   -   5        $ txtLastName��5      $
��Left=�6'   $��23��6B   $	��120��5      $��2��6   $��1��6+   6=   5      5       