using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace RKNotificationHub
{

	// @interface RKNotificationHub : NSObject
	[BaseType (typeof(NSObject))]
	interface RKNotificationHub
	{
		// -(id)initWithView:(UIView *)view;
		[Export ("initWithView:")]
		IntPtr Constructor (UIView view);

		// -(id)initWithBarButtonItem:(UIBarButtonItem *)barButtonItem;
		[Export ("initWithBarButtonItem:")]
		IntPtr Constructor (UIBarButtonItem barButtonItem);

		// -(void)setView:(UIView *)view andCount:(int)startCount;
		[Export ("setView:andCount:")]
		void SetView (UIView view, int startCount);

		// -(void)setCircleAtFrame:(CGRect)frame;
		[Export ("setCircleAtFrame:")]
		void SetCircleAtFrame (CGRect frame);

		// -(void)setCircleColor:(UIColor *)circleColor labelColor:(UIColor *)labelColor;
		[Export ("setCircleColor:labelColor:")]
		void SetCircleColor (UIColor circleColor, UIColor labelColor);

		// -(void)moveCircleByX:(CGFloat)x Y:(CGFloat)y;
		[Export ("moveCircleByX:Y:")]
		void MoveCircleByX (nfloat x, nfloat y);

		// -(void)scaleCircleSizeBy:(CGFloat)scale;
		[Export ("scaleCircleSizeBy:")]
		void ScaleCircleSizeBy (nfloat scale);

		// @property (nonatomic, strong) UIFont * countLabelFont;
		[Export ("countLabelFont", ArgumentSemantic.Strong)]
		UIFont CountLabelFont { get; set; }

		// -(void)increment;
		[Export ("increment")]
		void Increment ();

		// -(void)incrementBy:(int)amount;
		[Export ("incrementBy:")]
		void IncrementBy (int amount);

		// -(void)decrement;
		[Export ("decrement")]
		void Decrement ();

		// -(void)decrementBy:(int)amount;
		[Export ("decrementBy:")]
		void DecrementBy (int amount);

		// @property (assign, nonatomic) int count;
		[Export ("count")]
		int Count { get; set; }

		// -(void)hideCount;
		[Export ("hideCount")]
		void HideCount ();

		// -(void)showCount;
		[Export ("showCount")]
		void ShowCount ();

		// -(void)pop;
		[Export ("pop")]
		void Pop ();

		// -(void)blink;
		[Export ("blink")]
		void Blink ();

		// -(void)bump;
		[Export ("bump")]
		void Bump ();

		// @property (nonatomic) UIView * hubView;
		[Export ("hubView", ArgumentSemantic.Assign)]
		UIView HubView { get; set; }
	}
}
