# TeenyWeenyButtonAPI
VRCHAT Api To Easily Make Some Tiny Ass Buttons.

UPDATE TOGGLES FUNTIONALITY ADDED

![Showcase](https://i.imgur.com/tMRv25T.gif)

If You have any questions feel free to contact me By my discord username Lime/Pyro/Creed#1212!

if used throw a note with my discord name in the code :)

![Showcase](https://i.imgur.com/SgTUDys.gif)

![Example Code](https://i.imgur.com/9ExSMce.png)


HOW TO USE

       QMMiniButton MoveConsoleNormal = new QMMiniButton(Discreettab.GetMenuObject(), new Vector3(473.7256f, - 340.0173f, - 7.4222f), new Vector3(0, 0, 90), new Vector3(0.6f, 0.6f, 0f), "MoveToTab", "Moves Console To Top Right Corner", delegate
            {
                LimesFunctions.ChangeParent(GUIConsole, Discreettab.GetMenuObject());
                LimesFunctions.ChangeLocalPosition(GUIConsole, new Vector3(1f, -162.3245f, 1f));

            });
            
            QmMiniToggle MoveConsoleCorner = new QmMiniToggle(Discreettab.GetMenuObject(), new Vector3(473.7256f, -413.1389f, -7.4222f), new Vector3(0, 0, 90), new Vector3(0.6f, 0.6f, 0f), "MoveTocorner", "Moves Console To Top Right Corner", delegate
            {
                LimesFunctions.ChangeParent(GUIConsole, Window);
                LimesFunctions.ChangeLocalPosition(GUIConsole, new Vector3(310.1091f, -339.1273f, 0f));
                LimesFunctions.ChangeLocalScale(GUIConsole, new Vector3(3.7f, 2.5f, 2.5f));

            }, delegate
            {
                LimesFunctions.ChangeParent(GUIConsole, Discreettab.GetMenuObject());
                LimesFunctions.ChangeLocalPosition(GUIConsole, new Vector3(1f, -162.3245f, 1f));
                LimesFunctions.ChangeLocalScale(GUIConsole, new Vector3(8.9864f, 5.7471f, 1f));
                LimesFunctions.ChangeLocalRotation(GUIConsole, new Vector3(0, 0, 0));
            });
            
You can also change the background And Icon of the button but it is null by default.

OtherFunctions Included

![Other Functions](https://i.imgur.com/sE2zPqS.png)

Again Thanks For Checking out my Repo :)
