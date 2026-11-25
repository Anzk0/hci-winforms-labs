# Lab notes

## Labs 2 and 3: first form

These were about learning Visual Studio: the form designer, the properties panel, and how dragging a control onto a form generates code in `Form1.Designer.cs`. That file is meant to be left to the designer, so my own code goes in `Form1.cs`.

## Lab 4: two forms

`Form1` opens `Form2` and puts text in its textbox.

Once a form is closed it gets disposed, and calling `Show()` on it again throws. To handle that, the reference is set back to `null` when `Form2` closes (`f2.FormClosed += delegate { f2 = null; };`), and the button makes a new `Form2` whenever it's `null`.

To write to `f2.textBox1.Text` from `Form1`, the textbox's Modifiers had to be `public`. It works, but `Form1` is reaching into another form's controls. A property or constructor parameter on `Form2` would be the cleaner way.

## Lab 5: calculator

This lab was about separating logic from the UI. `Calculator.Add` lives in its own class, and the form only reads the inputs and shows the result.

**Known fault:** `Convert.ToDouble(number1.Text)` throws if a box is empty or contains letters, and nothing catches it, so the app crashes. Using `double.TryParse` and showing an error label would fix it.

The "exercise" version of lab 5 in my OneDrive was only an empty solution, so it isn't included.
