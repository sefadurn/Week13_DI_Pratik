# 📘 Dependency Injection Örneği – ASP.NET Core Web API

Bu proje, **Dependency Injection (DI)** kullanımını göstermek amacıyla hazırlanmış basit bir ASP.NET Core Web API uygulamasıdır.  

Projede `Teacher` ve `ClassRoom` sınıfları kullanılarak **Constructor Injection** ile bağımlılık yönetimi yapılmaktadır.  

---

## 🚀 Amaç
- **IOgretmen (Base Interface)** üzerinden bir sözleşme tanımlamak  
- **Teacher** sınıfının bu interface’i implement etmesi  
- **ClassRoom** sınıfının `IOgretmen` bağımlılığını constructor üzerinden alması  
- ASP.NET Core **DI Container** kullanılarak bağımlılıkların çözülmesi  
