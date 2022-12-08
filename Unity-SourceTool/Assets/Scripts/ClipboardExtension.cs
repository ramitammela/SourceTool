using UnityEngine;

public static class ClipboardExtension
{
    // Copy string into clipboard
    public static void CopyToClipboard(this string str)
    {
        GUIUtility.systemCopyBuffer = str;
    }
}