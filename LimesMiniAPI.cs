using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Discreet.SDK.Functions;
using UnityEngine.EventSystems;
using VRC.UI.Elements.Controls;
using UnityEngine.Events;
using VRC.UI.Elements;

namespace Discreet.SDK.APIS
{
    //teeny weeny button api created by Lime/Pyro/Creed#1212
    class QMMiniButton
    {
        public static GameObject MiniTemplate = GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Right/Container/InnerContainer/Friends/Cell_Wing_Toolbar/Button_PageDown");
        public static Image MiniIcon;
        public static GameObject MiniButton;
        public static List<GameObject> AllMinis = new List<GameObject>();
        public static string APINAME = "-LimesAPI";
        public QMMiniButton(GameObject parent, Vector3 pos, Vector3 rot, Vector3 scale, string name, string Tooltip, Action btnaction, Sprite Icon = null, Sprite Background = null)
        {
            MiniButton = LimesFunctions.EasyInstantiate(MiniTemplate, parent);
            MiniButton.name = name + APINAME;
            MiniButton.GetComponent<RectTransform>().localPosition = pos;
            MiniButton.GetComponent<RectTransform>().localEulerAngles = rot;
            MiniButton.GetComponent<RectTransform>().localScale = scale;
            LimesAPIFunctions.SetToolTip(Tooltip, MiniButton);
            MiniIcon = MiniButton.transform.Find("Icon").GetComponent<Image>();
            LimesAPIFunctions.OverrideSprite(MiniIcon, Icon);
            LimesAPIFunctions.OverrideSprite(MiniButton.transform.Find("Background").GetComponent<Image>(), Background);
            LimesAPIFunctions.Destroythisbcsimlazy(MiniButton.GetComponent<LayoutElement>());
            LimesAPIFunctions.Destroythisbcsimlazy(MiniButton.GetComponent<CanvasGroup>());
            LimesAPIFunctions.Destroythisbcsimlazy(MiniButton.GetComponent<UiTooltip>());
            LimesAPIFunctions.Destroythisbcsimlazy(MiniButton.GetComponent<ScrollRectPageButton>());
            MiniButton.AddComponent<Button>();
            MiniButton.GetComponent<Button>().onClick = new Button.ButtonClickedEvent();
            if (btnaction != null)
            {
               MiniButton.GetComponent<Button>().onClick.AddListener(UnhollowerRuntimeLib.DelegateSupport.ConvertDelegate<UnityAction>(btnaction));
            }
        }




        public static class LimesAPIFunctions
        {
            public static GameObject ReturnButtonObj()
            {
                return MiniButton;
            }
            public static void SetToolTip(string buttonToolTip, GameObject gameObject)//EDITED BLAZES API FUNCTION!!!  
            {
                gameObject.GetComponent<VRC.UI.Elements.Tooltips.UiTooltip>().field_Public_String_0 = buttonToolTip;
                gameObject.GetComponent<VRC.UI.Elements.Tooltips.UiTooltip>().field_Public_String_1 = buttonToolTip;
            }
            public static void OverrideSprite(Image image, Sprite sprite)
            {
                image.sprite = sprite;
                image.overrideSprite = sprite;
            }
            public static void ChangeColor(Image image, Color color)
            {
                image.color = color;
            }
            public static GameObject ReturnGameobjectifActive(GameObject gameObject)
            {
                while (gameObject == null) return null;
                return gameObject;
            }
            public static GameObject EasyInstantiate(GameObject target, GameObject parent)
            {
                GameObject Instantiated = UnityEngine.Object.Instantiate(ReturnGameobjectifActive(target), ReturnGameobjectifActive(parent).transform);
                return Instantiated;

            }
            public static void Destroythisbcsimlazy(Component gameObject)
            {
                UnityEngine.Object.DestroyImmediate(gameObject);
            }
        }
        
    }
    
}
