   M S B A M L   `   `   `  ����F  BNotepadV2--, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:NotepadV2__NotepadV2__  5   	   ?$clr-namespace:NotepadV2__.ViewModelsNotepadV2__.ViewModels  5   	       NotepadV2__.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:NotepadV2__     5   	   ;
viewmodels$clr-namespace:NotepadV2__.ViewModels     5   	     � Title$  	Notepad--��5	   	   $	��450��6   $	��605��6(    � DataContext 5
      *   $NotepadV2__.ViewModels.MainViewModel  5   
   .��5      ]� $��1q�6   .+�5   
   o� $	��Top=�6   $��38��6$   $	��Top=�61   $��2q�6I   
�������$��16(�6p   $
��Bold"�6~   ��5      �� 5       �� EndPoint$	 0,1&�6&    �� 
StartPoint$	 0,0&�65   .��5      �  � Color$ 	#FF3A60AD��6#    � Offset$ 0.528Q�65   � 5      $ 	#FF6A85D8��6#   $
 0.01Q�65   � 5      $ 	#FF3464C4��6#   $ 1Q�65   � 5      $ 	#FF202E7E��6#   $ 1Q�65   5       J� BitmapEffect 5      F� 5      @�5      m� 5      $
��File��6   
�������$��16(�6A   .@�5      m� $	��New��6   
����  �$��14(�6g   $��SemiBold"�6u    m� Command 6,   �� *File.NewCommand+ m� Icon 5       �� 5!      $��./Res/new.png��6$   5#      m� 5$      $
��Open��6   
����  �$��14(�6h   $��SemiBold"�6v    6-   �� *File.OpenCommand+ 5%      �� 5&      $��./Res/open.png��6$   5(      m� 5)      $
��Save��6   
����  �$��14(�6h   $��SemiBold"�6v    6-   �� *File.SaveCommand+ 5*      �� 5+      $��./Res/save.png��6$   5-      m� 5.      $��Save As��6   
����  �$��14(�6m   $��SemiBold"�6{    60   �� *File.SaveAsCommand+ 5/      �� 50      $��./Res/saveAs.png��6$   52      m� 53      $
��Exit��6   
����  �$��14(�6h   $��SemiBold"�6v    6-   �� *File.ExitCommand+ 54      �� 55      $��./Res/exit.png��6$   57      58      m� 5:      $
��Find��6   
�������$��16(�6B   .@�5;      m� $
��Find��6   
����  �$��14(�6i   $��SemiBold"�6w    6-   �� *Find.FindCommand+ 5<      �� 5=      $��./Res/find.jpg��6$   5?      m� 5@      $��Replace All��6   
����  �$��14(�6x   $��SemiBold"�6�    64   �� *Find.ReplaceAllCommand+ 5A      �� 5B      $��./Res/replace.png��6$   5D      m� 5E      $��Replace ��6   
����  �$��14(�6q   $��SemiBold"�6    61   �� *Find.ReplaceCommand+ 5F      �� 5G      $��./Res/replace.png��6$   5I      5J      m� 5L      $
��Help��6   
�������$��16(�6A   .@�5M      m� $��About��6   
����  �$��14(�6k   $��SemiBold"�6y    6/   �� *Help.HelpCommand+ 5N      �� 5O      $��./Res/about.png��6$   5Q      5R      m� 5T      -   5        $��
New Window��5T      
���  ��$��16(�6D   6t   5W      ]� 5Y   
   .+�5Z      �� -   5        $��textBlockPath��5]      $	��Top=�5Z       5[      �� *File+��5\      �� *File.Document.FilePath+��5^      �� *#!Document.IsTextChanged.Background+	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=��� 5c      -   5        $��textBox��5i      $	��Top=�5c      " �� VerticalScrollBarVisibility$ Visible=�5d       �� TextWrapping$
 Wrap=�5f       �� AcceptsReturn .  �� 
AcceptsTab .  5e      �� *File+��5l      �� *Document.Text+$	 TwoWay=�$
 PropertyChanged=�5n      5o      5p      