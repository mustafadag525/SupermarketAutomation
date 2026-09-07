# SupermarketAutomation




### Gıda Envanteri, Satış (POS) ve Mağaza Yönetim Otomasyonu

### 1. Technical Architecture & Environment (Teknik Mimari ve Altyapı)

The system is developed as an Enterprise-grade Windows Desktop Application designed to handle high-throughput inventory workflows, fast point-of-sale (POS) operations, and secure operator authentication. 

* **Core Language:** **C# (C-Sharp)** utilizing modern Object-Oriented Programming (OOP) paradigms including abstraction, inheritance, and encapsulation.
* **Target Framework:** **.NET WinForms** offering an intuitive, event-driven user interface optimized for desktop hardware acceleration.
* **Database Engine:** **Microsoft SQL Server** (gıda Database Instance) managed under System.Data.SqlClient provider.
* **Data Access Layer (DAL):** Strongly-typed **ADO.NET DataSets** (gıdaDataSet1, gıdaDataSet2) mapped directly to server-side tables via automated **TableAdapters** executing transactional SQL workflows with optimistic concurrency controls.

### 2. Advanced Database Schema & Entity Relational Model (Veritabanı ve Tablo Yapıları)

The relational database architecture is strictly optimized to ensure data integrity, prevent orphan records, and maintain ACID transaction compliance across standard retailing operations. 

 [TBLMarka] 1 ------ * [TBLModel]
                       
 [Kullanici] (Operators & System Administrators)
 [Urun]      (Active Dynamic Stock Management Warehouse)

### 2.1. Brand Control Ledger (dbo.TBLMarka)

Acts as the global registry for all parent manufacturers or distribution networks in the ecosystem. 

* **id** (int, Auto-Increment, Primary Key): The system-generated internal entity token.
* **marka** (varchar(50), Nullable): Universal text descriptor holding the precise brand identity.

### 2.2. Product Categorization Engine (dbo.TBLModel)

Establishes a strict parental hierarchy with the brand ledger to enforce structural categorization and cataloging consistency. 

* **id** (int, Auto-Increment, Primary Key): Unique model tracking signature.
* **markaid** (int, Foreign Key → TBLMarka.id): Explicitly maps each entry to a master brand profile.
* **urun** (varchar(50), Nullable): Sub-category reference defining the common commercial identifier.

### 2.3. Dynamic Warehouse Inventory Master (dbo.Urun)

The definitive data matrix tracking stock valuation, expiration safety boundaries, tax properties, and live quantities. 

* **Id** (int, Auto-Increment, Primary Key): Unique global barcode lookup identity.
* **marka** / **urun** (varchar(50)): Optimized de-normalized values used for rapid control bindings and reduced server join penalties.
* **uretimtarihi** (dateTime): Logs the industrial batch manufacturing timestamp.
* **alistarihi** (dateTime): Records the procurement intake chronological sequence.
* **alisfiyati** / **satisfiyati** (decimal / money standard): High-precision financial metrics governing profit margin metrics and ledger accounting audits.
* **kdv** (int): Regulatory value-added tax tier parameters.
* **resim** (varchar(150)): Dynamic pointer mapping local or network disk locations of physical product images.
* **miktar** (int): Core integer inventory variable updated by POS sales hooks and intake transactions.

### 2.4. System Operator Registry (dbo.Kullanici)

Governs localized role-based access management, security credentials, and accountability. 

* **Id** (int, Primary Key), **Adısoyadı** (varchar(50)), **Telno** (varchar(50)), **Adres** (varchar(50)), **Email** (varchar(50))
* **Kullaniciadi** & **Parola** (varchar(50)): Secure operational authentication parameters.
* **Gorev** (varchar(50)): Assigns system clearance privileges (e.g., Cashier, Store Manager, Admin).
* **Resim** (varchar(150)): Profiles image path of the application operator.

### 3. Class Domain & Component Engineering (Sınıf ve Nesne Yapısı)

Business logic is entirely separated from the user interface layers via structural backend controller classes: 

* **User Class (Kullanıcı):** Encapsulates active session tokens, credential evaluation logic, and access role routing behaviors.
* **Goods Class (Mal):** Executes low-level algorithms for computing dynamic commercial values, wholesale margins, and tracking raw supplier identifiers.
* **Client Class (Müşteri):** Manages structural models of profiles, contact properties, and structural transaction tracking hooks.
* **Transaction Class (Sepet_Satış):** Handles logical states of active shopping carts, pricing sub-totals, and structural checkout validations.
* **Data Core Class (Veritabanı):** Coordinates global client server string parameters, connection pools, and query execution threads.

### 4. End-to-End Application Workflow & Form Modules (Modüler İş Akışı)

### 4.1. Gatekeeper Authentication (Giriş Paneli & Yeni Kullanıcı Formları)

When the runtime lifecycle instantiates, users are routed exclusively to the secure entry environment. 

* **Query State Evaluation:** Looks up operator records via the Kullanici domain. If database logs are empty, a label trigger acts as a redirection link routing to the account generation utility form.
* **Exception Controls:** Invalid entries safely catch verification errors, abort landing sequences, and route structural telemetry logs to the UI view container via a standardized dialog **MessageBox**.

### 4.2. Central Management Dashboard (Anasayfa Formu)

Serves as the master programmatic workspace container orchestrating navigational focus across system forms. Includes command hooks to deploy modular forms for inventory adjustment, user grids, customer registries, live data integrations, and orderly application disposal mechanisms. 

### 4.3. Supply Chain Ingestion Interface (Ürün Ekleme Formu)

Allows staff to insert physical stock shipments into the SQL cluster. 

* **Operational Workflow:** Operators fill out manufacturer strings, processing costs, pricing indexes, and stock volume counts.
* **Media Pipeline:** Uses an embedded WinForms **PictureBox control** to browse local storage environments, establishing clean URI path mappings stored inside the database image properties.

### 4.4. Inventory Audit System (Ürün Listeleme Formu)

Provides clear oversight of live warehouse states. Entering an explicit **Product ID** invokes a targeted server filter command, fetching distinct entity rows instantly instead of forcing slow, manual grid navigation. 

### 4.5. Staff & Accounts Roster (Kullanıcı Ekleme & Listeleme Formları)

* **Form Workflow:** Registers new operators into the server profile databases.
* **Interactive Grids:** Selection events on the main data viewer automatically bind properties to bottom panel input boxes, facilitating instant updates.
* **Reporting Engine:** Features a dedicated documentation output command module (**Print Subsystem**) to render operator rosters onto hardware printing channels.

### 4.6. Corporate CRM Subsystem (Müşteri Ekleme & Listeleme Formları)

* **Data Profiles:** Standardizes records holding customer names, digital addresses, and geographical delivery nodes.
* **Core CRUD Architecture:** Driven by 4 definitive state controls: *Search, Delete, Update, and Cancel*. Target profiles are parsed instantly through isolated Customer ID evaluation hooks.

### 4.7. Point of Sale & Ledger Portals (Satış Yap & Yapılan Satışlar Modülleri)

* **POS Operation:** Couples validated clients with shopping cart models (sepet_satis).
* **Atomic Transactions:** Finalizing a trade batch fires database triggers that deduct sales quantities from the active miktar variable in the master database table, keeping tracking balances accurate.

### 4.8. Integration & Lifecycle Disposals (Döviz, Bize Ulaşın & Çıkış İşlemleri)

* **Currency Grid (Döviz Formu):** Integrates live data feeds to reference macro pricing environments.
* **Contact Interface (Bize Ulaşın Formu):** Provides a direct customer service portal within the store workspace.




* **Lifecycle Execution (Çıkış Butonu):** Traps application close signals behind confirmation dialog prompts, safely flushing transactional pipelines and memory spaces to protect data integrity.



<img width="520" height="442" alt="image" src="https://github.com/user-attachments/assets/3e5c191a-e2e3-497d-afec-7ca51b3746e6" />
<img width="512" height="456" alt="image" src="https://github.com/user-attachments/assets/c0cbe63c-94ed-4103-a008-53df4a03da21" />
<img width="838" height="562" alt="image" src="https://github.com/user-attachments/assets/2d6ab7ed-14e4-4987-987a-fbf784f32061" />
<img width="949" height="511" alt="image" src="https://github.com/user-attachments/assets/fd68f31f-ee71-45a6-bd99-8eb75ae06f1c" />
<img width="512" height="427" alt="image" src="https://github.com/user-attachments/assets/86bde05c-07c4-49fe-b24a-99358c3cd645" />
<img width="933" height="606" alt="image" src="https://github.com/user-attachments/assets/944c41ff-df7c-4d18-8b8b-e0ea0d8bc962" />
<img width="1040" height="531" alt="image" src="https://github.com/user-attachments/assets/4421e710-a1c5-4ae0-b4c7-8a9bb0d77062" />




