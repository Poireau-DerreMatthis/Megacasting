   M S B A M L   `   `   `  ����J  Fmegacasting.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:megacasting.WPF.Viewsmegacasting.WPF.Views  5      *    $megacasting.WPF.Views.PartenaireView   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:megacasting.WPF.Views     5      ���#393E46.��5	      � -   5          �Name$  myGrid��5	       � ColumnDefinitions 5
   
   �� 5      $��200pt �6   �� 5      $��* �6   �� 5      $��200pt �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��100pt �6   �� 5      $
��60pt �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $��1��6,   $��3��6>   .+�5      �� $��
Partenaire��6   $��25(�6)   $	��2pxq�67   $��Center=�6M   ���#F8F4EA6q   &   System.Windows.Controls.DataGrid  5      -   5          Name$ DataGridPartenaire��5      ���#00ADB5   AutoGenerateColumns$ False��5      $��1��5      $��Stretch=�5         SelectionMode$ Single=�5         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5      $	��190��5      ��5   3   �� *Partenaires+ �� SelectedItem 5      �� *SelectedPartenaire+	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn
   Header$	
 Nom��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *Nom+  5!      $
 	Telephone��6)    6<   �� *	Telephone+  5"      $

 Mail��6)    67   �� *Mail+5$      5%      �� 5&   
   $ Vertical=�6   $��1��6,   $��3��6:   .+�5'      �� $ 
Horizontal=�6   .+�5(      �� $��Nom :��6   
�������$	��5ptq�6;   �� 5)      -   5         ��Name$	 Nom��5)      $	��100��6O   $	��5ptq�6[   ��6'   �� *SelectedPartenaire.Nom+6j   �� 5*      $��Téléphone :��6   
�������$	��5ptq�6A   �� 5+      -   5        $ 	Telephone��5+      $	��100��6[   $	��5ptq�6g   ��6-   �� *SelectedPartenaire.Telephone+6v   �� 5,      $��Mail :��6   
�������$	��5ptq�6<   �� 5-      -   5        $
 Mail��5-      $	��100��6Q   $	��5ptq�6]   ��6(   �� *SelectedPartenaire.Mail+6l   5.      5/      �� 50   
   $ 
Horizontal=�6   $��Right=�6.   $��2��6J   $��3��6X   .+�51      �� -   5         ��Name$ ModifierPartenaire��51      $��Modifier��61   $
��30pt��6D   $
��50pt��6R   $	��5ptq�6_   ���#00ADB56�   �� 52      -   5        $ SupprimerPartenaire��52      $��	Supprimer��62   $
��30pt��6F   $
��50pt��6T   $	��5ptq�6a   ���#00ADB56�   �� 53      -   5        $ AjouterPartenaire��53      $��Ajouter��60   $
��30pt��6B   $
��50pt��6P   $	��5ptq�6]   ���#00ADB56   54      55      56      