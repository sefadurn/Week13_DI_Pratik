🚀 Amaç

IOgretmen (Base Interface) üzerinden bir sözleşme tanımlamak

Teacher sınıfının bu interface’i implement etmesi

ClassRoom sınıfının IOgretmen bağımlılığını constructor üzerinden alması

ASP.NET Core DI Container kullanılarak bağımlılıkların çözülmesi.

---

WebApiDIExample/
│
├── Interfaces/
│   └── IOgretmen.cs
│
├── Models/
│   ├── Teacher.cs
│   └── ClassRoom.cs
│
├── Controllers/
│   └── ClassRoomController.cs
│
├── Program.cs
└── appsettings.json
