   M S B A M L   `   `   `  ����J  Fmegacasting.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:megacasting.WPF.Viewsmegacasting.WPF.Views  5      %    megacasting.WPF.Views.OffreView   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:megacasting.WPF.Views     5      ���#393E46.��5	      � -   5          �Name$  myGrid��5	       � ColumnDefinitions 5
   
   �� 5      $��200pt �6   �� 5      $��* �6   �� 5      $��200pt �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��100pt �6   �� 5      $
��60pt �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $��1��6,   $��3��6>   .+�5      �� $��Offre��6   $��25(�6$   $	��2pxq�62   $��Center=�6H   ���#F8F4EA6l   &   System.Windows.Controls.DataGrid  5      -   5          Name$ DataGridOffre��5         AutoGenerateColumns$ False��5      ���#00ADB5$��1��5      $��Stretch=�5         SelectionMode$ Single=�5         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5      $	��190��5      ��5   .   �� *Offres+ �� SelectedItem 5      �� *SelectedOffre+	   Columns	 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Libelle��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *	Libelle+  5"      $
 Date début diffusion��6)    6G   �� *DateDebutDiffusion+  5#      $
 Date fin diffusion��6)    6E   �� *DateFinDiffusion+  5$      $
 Référence��6)    6<   �� *	Reference+  5%      $
 Description��6)    6>   �� *Description+  5&      $
 Metier��6)    69   �� *%#IdentifiantMetierNavigation.Libelle+  5'      $
 Contrat��6)    6:   �� *&$IdentifiantContratNavigation.Libelle+  5(      $
 Utilisateur��6)    6>   �� *!IdentifiantUserNavigation.Email+5*      5+      �� 5,   
   $ Vertical=�6   $��1��6,   $��3��6:   .+�5-      �� $ 
Horizontal=�6   .+�5.      �� $��	Libelle :��6   
�������$	��5ptq�6?   �� 5/      -   5         ��Name$ Libelle��5/      $	��100��6R   $	��5ptq�6^   ��6+   �� *SelectedOffre.Libelle+6m   �� 50      $��Date début diffusion :��6   
�������$	��5ptq�6L   (  "System.Windows.Controls.DatePicker  51      -   5          Name$ DateDebutDiffusion��51         SelectedDateFormat$ Short=�69   $	��5ptq�6�      Text 6T   �� *" SelectedOffre.DateDebutDiffusion+6�   �� 52      $��Date fin diffusion :��6   
�������$	��5ptq�6J     53      -   5        $ DateFinDiffusion��53      $ Short=�67   $	��5ptq�6�    6R   �� * SelectedOffre.DateFinDiffusion+6�   54      �� 55      $ 
Horizontal=�6   .+�56      �� $��Reférence :��6   
�������$	��5ptq�6A   �� 57      -   5        $ 	Reference��57      $	��100��6V   $	��5ptq�6b   ��6-   �� *SelectedOffre.Reference+6q   �� 58      $��Description :��6   
�������$	��5ptq�6C   �� 59      -   5        $ Description��59      $	��100��6Z   $	��5ptq�6f   ��6/   �� *SelectedOffre.Description+6f   �� 5:      $��Metier :��6   
�������$	��5ptq�6>   �� 5;      -   5         ��Name$ MetiersCombo��5;      $	��150��62    �� DisplayMemberPath$ Libelle��6^   $	��5ptq�6�   ��6>   �� *	Metiers+ 6z   �� *+)SelectedOffre.IdentifiantMetierNavigation+6�   5<      �� 5=      $ 
Horizontal=�6   .+�5>      �� $��	Contrat :��6   
�������$	��5ptq�6?   �� 5?      -	   5        $ ContratsCombo��5?      $	��100��63   $ Libelle��6d   $	��5ptq�6�   ��6?   �� *TypeContrats+ �� SelectedValuePath 6�   �� *,*SelectedOffre.IdentifiantContratNavigation+6�   �� 5@      $��Utilisateur :��6   
�������$	��5ptq�6C   �� 5A      -
   5        $ UtilisateursCombo��5A      $	��200��67   $ Email��6a   $	��5ptq�6�   ��6C   �� *Users+ 6{   �� *)'SelectedOffre.IdentifiantUserNavigation+6�   5B      5C      �� 5D   
   $ 
Horizontal=�6   $��Right=�6.   $��2��6J   $��3��6X   .+�5E      �� -   5         ��Name$ ModifierOffre��5E      $��Modifier��6,   $
��30pt��6?   $
��50pt��6M   $	��5ptq�6Z   ���#00ADB56|   �� 5F      -   5        $ SupprimerOffre��5F      $��	Supprimer��6-   $
��30pt��6A   $
��50pt��6O   $	��5ptq�6\   ���#00ADB56~   �� 5G      -   5        $ AjouterOffre��5G      $��Ajouter��6+   $
��30pt��6=   $
��50pt��6K   $	��5ptq�6X   ���#00ADB56z   5H      5I      5J      