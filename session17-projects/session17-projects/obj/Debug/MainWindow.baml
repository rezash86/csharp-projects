   M S B A M L   `   `   `  ����M  Isession17-projects, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:session17_projectssession17_projects  5   	   #    session17_projects.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:session17_projects     5   	   -   5          � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��175* �6   �� 5      $
��342* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   � $��2��6    5      �� 5      $
��Auto �6#   �� 5      $��* �6#    5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $��0��6   $��0��5       $��Customer Id��5!      �� 5"      -   5         ��Name$ CustomerIdLabel��5$      $��0��5"      $��1��5#      ��5%      �� *Customer.Id+�� 5&      $��1��6   $��0��5'      $��Customer Name��5(      �� 5)      -   5         ��Name$ CustomerNameTextBox��5)      $��1��5*      $��1��5+      ��5,      �� *Customer.LastName+�� 5-      $��2��6   $��0��5.      $��Recent Orders��5/      �� 50      -   5         ��Name$ 	OrderList��50      $��2��51      $��1��52      $	��100��53      ��54      �� *
OrderDates+55      �� 56      -   5         ��Name$ OnSave��56      $
��Save��57      $��3��58      $��3��59      $��75��5:      6    5;      &   System.Windows.Controls.DataGrid  5<   
   -   5          Name$ OrderItemsDataGrid��5<         AutoGenerateColumns .  $��1��5?      $��2��6    ��5=      �� *
OrderItems+	   Columns	 5@      0  *System.Windows.Controls.DataGridTextColumn  5A      -   5        idColumn��,  &System.Windows.Controls.DataGridColumn
   Header$
 Id��5B   %      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 5D   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5C   %   �� *Id+5D   %     5E      -   5        InsteuctionColumn��$
 Instructions��5G   %   $ SizeToHeader 5H   %    5F   %   �� *Instructions+5H   %     5I      -	   5        ProductIdColumn��$
 
Product Id��5K   %   $ SizeToHeader 5L   %    5J   %   �� *	ProductId+5L   %     5M      -
   5        QuantityColumn��$
 Quantity��5O   %   $ SizeToHeader 5P   %    5N   %   �� *
Quantity+5P   %     5Q      -   5        StoreIdColumn��$
 Quantity��5S   %   $ SizeToHeader 5T   %    5R   %   �� *	StoreId+5T   %     5V      -   5        TotalPriceColumn��$
 total Price��5X   %   $ SizeToHeader 5Y   %    5W   %   �� *
TotalPrice+5Y   %     5[      -   5        unitPriceColumn��$
 
Unit Price��5]   %   $ SizeToHeader 5^   %    5\   %   �� *	UnitPrice+5^   %   5`      5a      5b      