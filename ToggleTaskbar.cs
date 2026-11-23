using System;
using System.Runtime.InteropServices;

class Program {
    [DllImport("user32.dll")]
    private static extern IntPtr FindWindow(string className, string windowText);
    [DllImport("user32.dll")]
    private static extern int ShowWindow(IntPtr hwnd, int command);
    [DllImport("user32.dll")]
    private static extern bool IsWindowVisible(IntPtr hwnd);

    static void Main() {
        IntPtr hwnd = FindWindow("Shell_TrayWnd", "");
        if (IsWindowVisible(hwnd)) {
            ShowWindow(hwnd, 0); // Hide
        } else {
            ShowWindow(hwnd, 5); // Show
        }
    }
}
