   M S B A M L   `   `   `  ����J  FWPFProjectFinal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WPFProjectFinalWPFProjectFinal  5   	       WPFProjectFinal.Encipher   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WPFProjectFinal     5   	   -   5          � Title$  Encipher��5	   	   $��446.409��6   $��962.295��6+    � 
ResizeMode$ NoResize=�6;   
������� � WindowStyle$
 None=�6h    � 	Resources 5         TextBoxBaseControlTemplate �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers	 P� Property
 P� Value �� Value �� 
TargetName �� Property��%�  &	        �� 5   
   " ��6=   .R�5      �� $ Bd��5      #��z��5      
���   �#��z��5      $ 5��6E   ._�5      �� $ PART_ContentHost��6   5       5      P� 5      	 � {�
 .  . �5      �� # � ��63   $ Bd��6u    � ���� 5      # � ��63    � ��5      P� 5      	 � ��$

 Auto��6+   . �5      ��  � ��$	 100��61   5      P� 5      	 � ��$

 Auto��6,   . �5      ��  � ��$ 20��62   5      5      5       � TaskbarItemInfo 5       *  $System.Windows.Shell.TaskbarItemInfo  5!   
   .��5#      � -   5         �Name$ Moving��5#      $��0,0,0,-1q�6   .+�5$   
   �� $"��Исходный текст:��6   $
��Left=�6*   $��	10,10,0,0q�6E   $	��Top=�6X    J� RenderTransformOrigin$ -1.74,-10.727&�6p   $	��106��6�   �� 5%   
   $��	Ключ:��6   $
��Left=�6    $��
10,149,0,0q�6;   $	��Top=�6O   $ -1.74,-10.727&�6g   $	��106��6�   �� 5&   
   $0��*Преобразованный текст:��6   $
��Left=�61   $��
10,213,0,0q�6L   $	��Top=�6`   $ -1.74,-10.727&�6x   $	��148��6�   �� 5(   
   -   5         ��Name$ Sourse��5(   I   #��[  6   $
��Left=�6Y   $��	10,41,0,0q�6t    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��110��6�   $	��942��6�   �� 5)   
   -   5        $	 Key��5)   I   #��[  6   $
��Left=�6V   $��
10,180,0,0q�6q   $
 Wrap=�6�   $	��Top=�6�   $��25��6�   $	��207��6�   �� 5+   
   -   5        $ afterCipher��5+       �� 
IsReadOnly . $
��Left=�69   $��
10,244,0,0q�6T   $
 Wrap=�6h   $	��Top=�6|   $	��160��6�   $	��942��6�   �� 5-   
   -   5         ��Name$ 
FromCipher��5-      $��Расшифровать��6'    d� 	IsChecked$ FalseY�6>   $
��Left=�6Q   $��246,190,0,0q�6l   $	��Top=�6�   $ 0.352,1.533&�6�   6�   �� 5.   
   -   5        $ ToCipher��5.      $��Зашифровать��6%   $
 TrueY�6;   $
��Left=�6L   $��246,170,0,0q�6g   $	��Top=�6|   6�   �� 5/   
   $"��Преобразование��6   $
��Left=�6)   $��225,151,0,0q�6D   $	��Top=�6Y   $ -1.74,-10.727&�6q   $	��122��6�   $��24��6�   $��10(�6�   �� 51   
   -   5         ��Name$ OpenFile��51      $��Из файла��6#   $
��Left=�66   $��
10,414,0,0q�6Q   $	��Top=�6e   $	��106��6}   6�   �� 52   
   -	   5        $ Solve��52      $��Рассчитать��6    $
��Left=�65   $��246,211,0,0q�6P   $	��Top=�6e   $	��106��6}   6�   �� 53   
   -
   5        $ 
SaveAsFile��53      $��Сохранить��6%   $
��Left=�69   $��121,414,0,0q�6T   $	��Top=�6i   $	��106��6�   $ 
0.472,1.15&�6�   �� 55   
   -   5        $ ClosingWindow��55      $
��Left=�6(   $��	935,0,0,0q�6C   $	��Top=�6V   .��56      �� -   5         ��Name$ CloseWindow��56      $��Images\close-window.png��6)   $��23��6J   $��23��6V   $ 	0.548,0.5&�6a   57      59      5;      