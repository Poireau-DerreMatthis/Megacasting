   M S B A M L   `   `   `  ����J  Fmegacasting.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:megacasting.WPF.Viewsmegacasting.WPF.Views  5      $    megacasting.WPF.Views.PackView   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:megacasting.WPF.Views     5      ���#393E46.��5	      � -   5          �Name$  myGrid��5	       � ColumnDefinitions 5
   
   �� 5      $��200pt �6   �� 5      $��* �6   �� 5      $��200pt �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��100pt �6   �� 5      $
��60pt �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $��1��6,   $��3��6>   .+�5      �� $��Utilisateur��6   $��25(�6*   $	��2pxq�68   $��Center=�6N   ���#F8F4EA6r   &   System.Windows.Controls.DataGrid  5      -   5          Name$ DataGridPack��5         AutoGenerateColumns$ False��5      ���#00ADB5$��1��5      $��Stretch=�5         SelectionMode$ Single=�5         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5      $	��190��5      ��5   -   �� *Packs+ �� SelectedItem 5      �� *SelectedPack+	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn
   Header$
 Libelle��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *	Libelle+  5!      $
 NombreOffre��6)    6>   �� *NombreOffre+  5"      $
 Tarif��6)    68   �� *Tarif+5$      5%      �� 5&   
   $ Vertical=�6   $��1��6,   $��3��6:   .+�5'      �� $ 
Horizontal=�6   .+�5(      �� $��	Libelle :��6   
�������$	��5ptq�6?   �� 5)      -   5         ��Name$ Libelle��5)      $	��100��6Q   $	��5ptq�6]   ��6+   �� *SelectedPack.Libelle+6l   �� 5*      $��Nombre d'offre :��6   
�������$	��5ptq�6F   �� 5+      -   5        $ NombreOffre��5+      $	��100��6Y   $	��5ptq�6e   ��6/   �� *SelectedPack.NombreOffre+6t   �� 5,      $��Tarif :��6   
�������$	��5ptq�6=   �� 5-      -   5        $ Tarif��5-      $	��100��6M   $	��5ptq�6Y   ��6)   �� *SelectedPack.Tarif+6h   5.      5/      �� 50   
   $ 
Horizontal=�6   $��Right=�6.   $��2��6J   $��3��6X   .+�51      �� -   5         ��Name$ ModifierPack��51      $��Modifier��6+   $
��30pt��6>   $
��50pt��6L   $	��5ptq�6Y   ���#00ADB56{   �� 52      -   5        $ SupprimerPack��52      $��	Supprimer��6,   $
��30pt��6@   $
��50pt��6N   $	��5ptq�6[   ���#00ADB56}   �� 53      -   5        $ AjouterPack��53      $��Ajouter��6*   $
��30pt��6<   $
��50pt��6J   $	��5ptq�6W   ���#00ADB56y   54      55      56      