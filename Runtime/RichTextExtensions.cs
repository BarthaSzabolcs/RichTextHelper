using UnityEngine;

namespace BarthaSzabolcs.RichTextHelper
{
    public static class RichTextExtensions
    {
        public static string Bold(this string text)
        {
            return $"<b>{text}</b>";
        }

        public static string Italic(this string text)
        {
            return $"<i>{text}</i>";
        }

        public static string Color(this string text, Color color)
        {
            return $"<color=#{ColorUtility.ToHtmlStringRGBA(color)}>{text}</color>";
        }

        public static string Color(this string text, string color)
        {
            return $"<color={color}>{text}</color>";
        }

    }
}
