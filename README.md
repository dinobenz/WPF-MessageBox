WPF-MessageBox
==============

Custom WPF MessageBox

![alt tag](https://raw.github.com/dinobenz/WPF-MessageBox/master/src/WPF-MessageBox/Image/Mockup.png)

Usage
==============
Display message text
```
MessageBoxWindow.Show(this, "Put your message here.");
```

Display message text and caption
```
MessageBoxWindow.Show(this, "Put your message here.", "Put your caption here");
```

Display message text, caption and Yes/No button
```
MessageBoxResult msgResult = MessageBoxWindow.Show(this, "Put your message here.", "Put your caption here", MessageBoxButton.YesNo);
```

Display message text, caption, button and icon
```
MessageBoxWindow.Show(this, "Put your message here.", "Put your caption here", MessageBoxButton.OK, MessageBoxImage.Warning);
```