   M S B A M L   `   `   `  ����B  >WebShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WebShopWebShop  5   	       WebShop.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WebShop     5   	   -   5          � Title$  
MainWindow��5   	   $	��900��6   $
��1200��6)    � WindowState$ 	Maximized=�66   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��	DataGrid1��5
         CanUserAddRows .  $��Center=�6;      HeadersVisibility$ Column=�6_      AutoGenerateColumns .  $
��Left=�6�   $	��722��6�   $	��Top=�6�   $
��1170��6�   $��	10,10,0,0q�6  ��6�   �� *
listaOsoba+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ OsobaId��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6R   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *	OsobaId+6R     5      $ Ime i Prezime��6%   $ * 6[    6<   �� *
ImePrezime+6[     5      $ Telefon��6%   $ * 6R    66   �� *	Telefon+6R     5      $ Ulica��6%   $ * 6N    64   �� *Ulica+6N     5      $ 
Kucni broj��6%   $ * 6W    69   �� *	KucniBroj+6W     5      $ Postanski broj��6%   $ * 6_    6=   �� *PostanskiBroj+6_     5      $ Mesto��6%   $ * 6N    64   �� *Mesto+6N     5      $ Sta je poruceno��6%   $ * 6`    6>   �� *StaPorucujete+6`     5      $ Kolicina��6%   $ * 6T    67   �� *
Kolicina+6T   5      �� 5   
   -   5        $��ButtonObrisi��5      $��Obrisi��6%   $
��Left=�66   $��
10,785,0,0q�6Q   $	��Top=�6e   $��75��6}   6�   �� 5   
   -   5        $��ButtonOsvezi��5      $��Osvezi��6%   $
��Left=�66   $	��Top=�6Q   $��75��6i   $��119,785,0,0q�6t   6�   5      5      