# Xamarin RKNotificationHub
A Xamarin.iOS library for adding badges to any UIView, UIBarButtonItem, or position on the screen. You can also animate your badges!

## Installation

Use NuGet!
`Install-Package RKNotificationHub`
https://www.nuget.org/packages/RKNotificationHub/

## Usage

Once installed, create an `RKNotificationHub`.

```csharp
var hub = new RKNotificationHub.RKNotificationHub(myView);
// or...
var hub = new RKNotificationHub.RKNotificationHub(myUIBarButtonItem);
// or...
var hub = new RKNotificationHub.RKNotificationHub();
```

You can then set or change the view or position of the circle:

```chsarp
hub.SetView(myView);
hub.SetCircleAtFrame(myFrame);
```

You can also set the color:

```csharp
hub.SetCircleColor(circleColor, labelColor);
```

Then you can change the value of the notifcation:

```charp
hub.Increment();
hub.IncrementBy(10);
hub.Decrement();
hub.DecrementBy(10);
hub.HideCount();
hub.ShowCount();
```

And of course you can play with styles and animations!

```csharp
hub.Bump();
hub.Blink();
hub.Pop();
hub.MoveCircleByX(x,y);
hub.ScaleCircleSizeBy(3);
```
