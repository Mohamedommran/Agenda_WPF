   M S B A M L   `   `   `  ����  
Agenda_WPF    Agenda_WPF.customer   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� Title$  customer��5      .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
customerDG��5
         AutoGenerateColumns$ False��6'      
IsReadOnly$
 True��6C      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Customer Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *
IdCustomer+6[     5      $ 	Last Name��6%    68   �� *
LastName+6W     5      $ 
First Name��6%    69   �� *	FirstName+6Y     5      $ E-mail��6%    65   �� *Mail+6P     5      $ Phone Number��6%    6;   �� *PhoneNumber+6]     5      $ Budget��6%    65   �� *Budget+6R   5      5      5      