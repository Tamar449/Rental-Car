# Car Rental – אתר להשכרת רכבים
## תאור הפרויקט:

אתר אינטרנט להשכרת רכבים לפי שעה עבור מנויי המערכת. האתר מציע ממשק נוח ויעיל למשתמשים ולמנהלי החברה, עם מגוון יכולות ניהול, חיפוש ותשלום.

פונקציונליות למשתמש:

צפייה בכל הרכבים במערכת עם סינון חכם לפי פרמטרים כגון: חברה, דגם, מספר מקומות, זמינות ועוד.

בחירת רכב להשכרה וקבלת מיקום מדויק של הרכב.

עדכון החזרת רכב וחישוב עלות ההשכרה לפי משך השימוש ומחיר הדלק בזמן אמת.

צפייה בהיסטוריית ההשכרות האישית.

פונקציונליות למנהל:

צפייה בכל הרכבים וההשכרות במערכת.

הוספה, עריכה ומחיקה של רכבים.

ניהול נתוני השכרות בצורה מרכזית.

## טכנולוגיות הפרויקט

### צד שרת – C#

בנוי במודל רב-שכבתי (Layered Architecture) עם עקרונות SOLID.

שימוש בממשקים (Interfaces) לצורך הזרקת תלויות (Dependency Injection) והפרדה בין שכבות.

מבוסס גישה של Database First.

עבודה מול בסיס הנתונים SQL Server.

### צד לקוח – React

פיתוח קומפוננטות פונקציונליות תוך שימוש ב־Hooks.

ניהול state עם Redux.

שימוש נרחב בספריית העיצוב MUI ליצירת ממשק משתמש מודרני ונגיש.

