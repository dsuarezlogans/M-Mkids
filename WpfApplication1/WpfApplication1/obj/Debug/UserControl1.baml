   M S B A M L   `   `   `  ����  WpfApplication1    MMKids.UserControl1   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      h dMicrosoft.Expression.Interactions, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bei9http://schemas.microsoft.com/expression/2010/interactions  6G   -   5          >�Name$  
ImageHover��5	      $	��160��6   $	��110��6#    J� Effect 5
      3  -System.Windows.Media.Effects.DropShadowEffect  5         Opacity$ 0Q�6   .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5         	EventName$ 
MouseLeave��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      =  7Microsoft.Expression.Interactivity.Core.GoToStateAction  -   5        NormalAction��   UseTransitions .     	StateName$ Normal��5   E   8  2System.Windows.Interactivity.TargetedTriggerAction   TargetObject 6X   �� 	 �� ElementName$	 
ImageHover��5        5      $ MouseLeftButtonDown��6   . 5        -   5        MouseOverAction��$ 	MouseOver��5   1    .   6^   �� $	 
ImageHover��5        5      $ 
MouseEnter��6   . 5        -   5        MouseHoverAction�� .  $ 
MouseHover��5   y    62   �� $	 
ImageHover��6y   5      .��5      � -   5        
 �Name$
 
LayoutRoot��5      '  !System.Windows.VisualStateManager   VisualStateGroups 5      %  System.Windows.VisualStateGroup  5      -   5        VisualStateGroup��   States. 5       	  System.Windows.VisualState	  -   5        
Normal��5      	  5      -   5        	MouseOver�� 	  
Storyboard. 5      �� .��5      U�  �� TargetProperty$ (FrameworkElement.Width)�6&    �� 
TargetName$ 
ImageHover��6[   .\�5    	   9
  3System.Windows.Media.Animation.EasingDoubleKeyFrame
   O� KeyTime$ 0:0:0.3��6    O� Value$	 210Q�60   5!   	   U� 5"      $ (FrameworkElement.Height)�6&   $ 
ImageHover��6\   .\�5#   	   
  $ 0:0:0.3��6   $	 260Q�60   5$   	   5%      5&      	  5'      -	   5        
MouseHover��. 5(      �� .��5)      �� $1 +(UIElement.Effect).(DropShadowEffect.Color)�6%   $ 
ImageHover��6m   .g�5*   	   8  2System.Windows.Media.Animation.EasingColorKeyFrame   �� KeyTime$ 0��6    �� Value$ 	#FFEAEAEA��6)   5+   	   T� 5,      $9 3(UIElement.Effect).(DropShadowEffect.RenderingBias)�6&   $ 
ImageHover��6v   ..�5-   	   i�  R� KeyTime$ 0��6    0  *System.Windows.Media.Effects.RenderingBias   Quality R� Value# Z 6,   5.   	   U� 5/      $3 -(UIElement.Effect).(DropShadowEffect.Opacity)�6&   $ 
ImageHover��6p   .\�50   	   
  $ 0��6   $ 1Q�6*   51   	   52      53      54      56      57      