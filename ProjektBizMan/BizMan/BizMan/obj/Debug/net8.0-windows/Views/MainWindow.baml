   M S B A M L   `   `   `  ����A  =BizMan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:BizManBizMan  5   	       BizMan.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:BizMan     5   	     � Title$  
MainWindow��5   	   $	��800��5	   	   $
��1100��6    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowState$ 	Maximized=�5   	   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ EmployeeListView��5      $��0��6O   $��0,0,0,10q�6\   ��6-   �� *	Employees+ �� View 5      �� 5      .P�5      �� $��ID��6%    �� Width$ 50��6U    �� DisplayMemberBinding 61   �� *ID+6U   �� 5      $��
First Name��6%   $	 100��6d    69   �� *	FirstName+6d   �� 5      $��	Last Name��6%   $	 100��6b    68   �� *
LastName+6b   �� 5      $��Position��6%   $	 120��6a    67   �� *
Position+6a   �� 5      $��
Department��6%   $	 120��6e    69   �� *
Department+6e   �� 5      $��	Hire Date��6%   $	 120��6b    68   �� *
HireDate+6b   �� 5      $��Salary��6%   $ 80��6]    65   �� *Salary+6]   �� 5      $��Email��6%   $	 150��6[    64   �� *Email+6[   �� 5      $��Phone��6%   $	 120��6a    64   �� *PhoneNumber+6a   �� 5      $��Address��6%   $	 150��6_    66   �� *	Address+6_   �� 5      $
��City��6%   $	 100��6Y    63   �� *City+6Y   �� 5       $��County��6%   $	 100��6]    65   �� *County+6]   �� 5!      $��PostCode��6%   $ 80��6a    67   �� *
PostCode+6a   �� 5"      $��Country��6%   $	 100��6_    66   �� *	Country+6_   �� 5#      $��
Birth Date��6%   $	 120��6f    69   �� *DateOfBirth+6f   5$      5&      �� 5(   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $
��Left=�6;   .+�5)      �� -   5        $��	AddButton��5)      $��Dodaj��6&   $��80��66   $��0,0,10,0q�6A   6S   �� 5*      -   5        $��RemoveButton��5*      $��Usuń��6)   $��80��68   $��0,0,10,0q�6C   6U   �� 5+      -   5        $��
EditButton��5+      $��Edytuj��6'   $��80��68   6C   5,      5-      50      