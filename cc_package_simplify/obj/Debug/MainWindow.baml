   M S B A M L   `   `   `  ����N  Jcc_package_simplify, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:cc_package_simplifycc_package_simplify  5   	   G(clr-namespace:cc_package_simplify.Commoncc_package_simplify.Common  5   	   $    cc_package_simplify.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:cc_package_simplify     5   	   ;common(clr-namespace:cc_package_simplify.Common     5   	   -   5        $��window��5        � Title$
  Ahri��5	   	   $	��600��6   $	��360��6#   $��FiraCode)�5
   	   $��
ExtraLight"�6    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�6    � WindowStyle$
 None=�5   	    � AllowsTransparency . ��66   Z�  � 	Resources 5       �� 
TargetType   CloseButtonTemplate �� Triggers P� Property	 P� Value
 �� 
TargetName �� Property �� Value  LoginBtnTemplate �� CornerRadius 
 APPLog �� ImageSource  TextBox.Static.Border �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border  UserNameTextBoxStyle �� 
TargetType-  'System.Windows.Input.KeyboardNavigation ��Name J� SnapsToDevicePixels � ColumnDefinitions ��Name �� Triggers ]� 
Conditions �� Property �� Value  PasswordBoxStyle  VlidationCodeTextBoxStyle J� Opacity��%  &	        &	 �    &	 J    &	 �    &	 �    &	 �    &	 �    7  7  7  &	 4
    7  7  7  &	 �    7  7  7  �� 5   
   " ��6   .R�5      �� $
��back��6.   
������ ._�5      F� +����        � �  � �     � � �     	
�������$��1��6B   $��Center=�6V   $��Center=�6q   5       5      P� 5       �@J�IsMouseOver	 . . �5      �� $

 back��6    � �� �	#22FFFFFF6E   5      P� 5       � ��	 . . �5      �� $

 back��6    � �� �	#44FFFFFF6E   5      5      �� 5   
   " ��6   .R�5      �� ���#007DFA$ 5��6*   ._�5      � .+�5      �� $
��back��6E   $ 4��6   ���	#22FFFFFF$y�Hidden=�6Q   �� 5      #��z��6%   #��z��5    !   $��Center=�5!   !   $��Center=�5"   !   5#      5$       5%      P� 5&       �@J�IsMouseOver	 . . �5'      �� $

 back��6C    � y�$ Visible=�63   6C   5(      5*      �� 5,   
   $# ./Assets/Imgs/icon-256@2x.png��6$   �� 5-   
   $ 	#FFABAdB3��68   �� 5.   
   $ 	#FF7EB4EA��6;   �� 5/   
   $ 	#FF569DE5��67   �� 50   
   " ��6-   .�51      ��  � ��# � ��6+   �� 52       � ��8   6,   �� 53       � ��# � ��6+   �� 54       � ��$ 1q�60   �� 55       �@ TabNavigation$
 None=�6A   �� 56       � ��$
 Left=�6;   �� 57       �@�FocusVisualStyle 61   Z� �� 58       �@J�	AllowDrop . 6*   �� 59       �@��PanningMode$ VerticalFirst=�69   �� 5:       �@��IsFlicksEnabled .  67   �� 5;       � �� 5<      �� 5=      " ��6&   .R�5>      �� $ border��6!   #��z��61   #��z��5?   !   #��z��5@   !    . $ 5��5B   !   ._�5C      �  5D   "   �� 5E   &   $��40 �67   �� 5F   &   .+�5H   "   �� $	����6,   $��./Assets/Fonts/#iconfont)�6<   $��20(�6b   $��Center=�6p   $��Center=�6�   ���#DDD$
��10,8q�5I   >   �� 5J   "   $ PART_ContentHost��6/   $��1��6I   |�.  $��Hidden=�5K   A   $��Hidden=�5L   /   $��Center=�5M   /   $��20��6J   $��2��6Y   $	��0,9q�6m   5N      5O       5P      P� 5Q       � {�	 .  . �5R   "   �� $
 border��6<    �@J�Opacity$
 0.56Q�6P   5S      P� 5T       �@J�IsMouseOver	 . . �5U   "   �� $
 border��6@   8   � ��6T   5V      P� 5W       �@J�IsKeyboardFocused	 . . �5X   "   �� $
 border��6@   8   � ��6T   5Y      5[      5]       5^      ]� 5_       5`      �� 5a      + �@��#IsInactiveSelectionHighlightEnabled . 6S   �� 5b       �@��IsSelectionActive .  6A   ./�5d      ��  �@��SelectionBrush# � /�67   5e      5g      �� 5h   
   " G�6)   .�5i      ��  �@G�PasswordChar$	 ●��6-   �� 5j       � ��# � ��6+   �� 5k       � ��8   6,   �� 5l       � ��# � ��6+   �� 5m       � ��$ 1q�60   �� 5n       �@ TabNavigation$
 None=�6A   �� 5o       � ��$
 Left=�6;   �� 5p       �@�FocusVisualStyle 61   Z� �� 5q       �@J�	AllowDrop . 6*   �� 5r       �@��PanningMode$ VerticalFirst=�69   �� 5s       �@��IsFlicksEnabled .  67   �� 5t       � �� 5u      �� 5v      " G�6&   .R�5w      �� $ border��6!   #��z��61   #��z��5x   !   #��z��5y   !    . $ 5��5z   <   ._�5{      �  5|   "   �� 5}   &   $��40 �67   �� 5~   &   .+�5�   "   �� $	����6,   $��./Assets/Fonts/#iconfont)�6<   $��20(�6b   $��Center=�6p   $��Center=�6�   ���#DDD$
��10,8q�5�   >   �� 5�   "   $ PART_ContentHost��6/   $��1��6I   |�.  $��Hidden=�5�   A   $��Hidden=�5�   /   $��Center=�5�   /   $��20��6J   $��2��6Y   $	��0,9q�6m   5�      5�       5�      P� 5�       � {�	 .  . �5�   "   �� $
 border��6<    �@J�Opacity$
 0.56Q�6P   5�      P� 5�       �@J�IsMouseOver	 . . �5�   "   �� $
 border��6@   8   � ��6T   5�      P� 5�       �@J�IsKeyboardFocused	 . . �5�   "   �� $
 border��6@   8   � ��6T   5�      5�      5�       5�      ]� 5�       5�      �� 5�      + �@G�#IsInactiveSelectionHighlightEnabled . 6S   �� 5�       �@G�IsSelectionActive .  6A   ./�5�      ��  �@G�SelectionBrush# � /�67   5�      5�      �� 5�   
   " ��62   .�5�      ��  � ��# � ��6+   �� 5�       � ��8   6,   �� 5�       � ��# � ��6+   �� 5�       � ��$ 1q�60   �� 5�       �@ TabNavigation$
 None=�6A   �� 5�       � ��$
 Left=�6;   �� 5�       �@�FocusVisualStyle 61   Z� �� 5�       �@J�	AllowDrop . 6*   �� 5�       �@��PanningMode$ VerticalFirst=�69   �� 5�       �@��IsFlicksEnabled .  67   �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      �� $ border��6!   #��z��61   #��z��6]   #��z��6�    . $ 5��5�   <   ._�5�      �  5�   "   �� 5�   &   $��40 �67   �� 5�   &   �� 5�   &   $��80 �67   .+�5�   "   �� $	����6,   $��./Assets/Fonts/#iconfont)�6<   $��24(�6b   $��Center=�6p   $��Center=�6�   ���#DDD$
��10,8q�5�   >   �� 5�   "   $ PART_ContentHost��6/   $��1��6I   |�.  $��Hidden=�5�   A   $��Hidden=�5�   /   $��Center=�5�   /   $��20��6J   $��2��6Y   $	��0,9q�6m   �� 5�   "   $��2��6X   $��Center=�6h   $��Center=�6�   $	 0.5Q�6�   ��6(   �� *loginModel.ValidationCodeUrl+6�   5�      5�       5�      P� 5�       � {�	 .  . �5�   "   �� $
 border��6<    �@J�Opacity$
 0.56Q�6P   5�      P� 5�       �@J�IsMouseOver	 . . �5�   "   �� $
 border��6@   8   � ��6T   5�      P� 5�       �@J�IsKeyboardFocused	 . . �5�   "   �� $
 border��6@   8   � ��6T   5�      5�      5�       5�      ]� 5�       5�      �� 5�      + �@��#IsInactiveSelectionHighlightEnabled . 6S   �� 5�       �@��IsSelectionActive .  6A   ./�5�      ��  �@��SelectionBrush# � /�67   5�      5�      5�      .��5�      �� $��5q�6   
�������$ 10��6+    J� Effect 5�   
   3  -System.Windows.Media.Effects.DropShadowEffect  5�         Color$
 Gray��6      ShadowDepth$ 0Q�6,      
BlurRadius$ 5Q�6<      Opacity$	 0.3Q�6K      	Direction$ 0Q�6Y   ._�5�   
   �   � RowDefinitions  5�      �� 5�      $
��1.8* �6    �� 5�      $��3* �6    �� 5�      $	��100 �6    .+�5�      �� -   5        ���#007DFA$ 	10,10,0,0��5�   *   6C   �� 5�      $	��Top=�6   $��Right=�6-   $��40��6I   $��30��6T   #��[  5�      ��5�      �� *CloseWindowCommand+��5�      �� ! �� ElementName$! window��5�      �� 5�      $��Center=�6   .+�5�      �� $	��110��6   $	��110��6%    5�        5�      $ White��6+   $ 0Q�69   $ 5Q�6I   $	 0.3Q�6X   $ 0Q�6f   ._�5�      �� $	��100��6   $	��100��6)   #��[ 66   5�      �� 5�      $&�� Cocos Creator 试玩打包工具��6   $��Light"�68   $��Center=�6K   
�������$��18(�6{   $��0,20,0,0q�6�   5�      � 5�      $��1��6   $��20,10q�6      5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      $��23��6$   $
��auto �63   .+�5�      �� $��40��6   $��16(�6K   ���#555#���  6k   ��6&   �� *loginModel.UserName+6k   G� 5�      $��1��6   $��40��6+   #���  67   $��16(�5�      ���#555/   )cc_package_simplify.Common.PasswordHelper"   Attach" . #   Password# 5�      �� *loginModel.Password+�� 5�      $��2��6   $��40��6'   $��16(�6^   ���#555#���  6~   ��63   �� *loginModel.ValidationCode+6~   �� 5�      $��
登    录��6   $��3��6*   $��40��67   
�������$��16(�5   ,   #��[ 5     ��5     �� *LoginCommand+�� 5     
���  ��$��4��6R   $��13(�6_   $��Center=�5     $
��Wrap=�5     $ �� 
LineHeight$$ 22��60   ��5     �� *loginModel.ErrorMsg+5  0   5     � 5     $��2��6   $
��20,0q�6      5     �� 5	     $��20 �6$   �� 5
     .+�5     �  5     �� 5     �� 5     $��30 �6+   �� 5     .+�5     �� ���#DDD$��0,0,0,1q�60   $��Center=�6J   �� 5     ���#DDD$��0,0,0,1q�60   $��Center=�6J   $��2��6e   �� 5     $��OR��6    $��1��6*   ���#CCC$��Center=�6L   $��Center=�6g   5     A� 5     % A� Columns$% 5��6   $��1��6*    5     ��%o  '��       �� 5     " ��6    .�5     ��  � �� �#DDD6;   �� 5      � ��$ 40(�69   �� 5      � ��$ Center=�6D   �� 5      � ��$ Center=�6B   �� 5      � ��$ ./Assets/Fonts/#iconfont)�6;    5     P� 5  "    �@J�IsMouseOver	 . . �5   &   ��  � �� �#007DFA6C   5!  #   5#     5$     .+�5%     �� $	����6    �� 5&     �� 5'     $	����6    �� 5(     �� 5)     $	����6    5*     5+     5,     5-     5.     