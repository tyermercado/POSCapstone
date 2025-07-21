# ☕ Taza Mia POS System

**Taza Mia POS System** is part of the **Ezpresso: All-in-One Coffee System**, a comprehensive multi-device solution designed to streamline operations in coffee shops and cafés. This specific module is assigned to and developed for handling in-store sales and inventory management.

---

## 📡 Ezpresso System Integration

The **Ezpresso System** is a multi-device solution composed of the following modules:

| Module | Description |
|--------|-------------|
| 📱 **Ordering System** | Customer-facing ordering interface (e.g., tablet or kiosk). Sends orders directly to the POS. |
| 💻 **Taza Mia POS System** *(this module)* | Manages order processing, inventory, and payment. |
| 🍳 **Kitchen Display System (KDS)** | Displays active orders for kitchen staff, triggered by POS. |
| 🖥️ **Queueing Display System** | Shows order status and notifies customers when orders are ready. |

### 🔄 System Workflow

1. Customer places order via **Ordering System**.
2. Order is sent to the **Taza Mia POS System**.
3. POS forwards the order to the **Kitchen Display System**.
4. Once ready, staff update order status in POS.
5. **Queueing Display System** reflects order readiness.

---
  

🖥️ **Each module was presented on a separate device.** This repository focuses on the **Taza Mia POS System** module.

---


## 💻 Tech Stack

- **Language**: VB.NET (WinForms)
- **Database**: MySQL
- **Connector**: MySQL Connector/NET
- **Architecture**: Desktop Client-Server
- **UI Components**: Windows Forms, .NET Chart Controls

---

## 👥 User Roles

### 🔐 Shared Login View

Both roles log in using the **same login form**, but credentials determine the dashboard and features shown.

---

## 🛠️ Features

### 🧑‍💼 Administrator Dashboard

- 🛒 Product Management
- 📊 Sales Summary with Pie Charts
- ⭐ Best Selling Products
- 🏷️ Discount Management
- 📦 Stock Inventory Control
- ❌ Cancel Orders
- 🔐 Secure Logout

### 💼 Cashier Interface

- 💳 Process Sales Transactions
- 🔍 Product Lookup
- ❌ Cancel Ongoing Orde
- 🔐 Restricted Access to Admin Controls

---

## 🖼️ Screenshots
![POS Screenshot](https://github.com/tyermercado/POSCapstone/blob/master/tm_login.png)

![POS Screenshot](https://github.com/tyermercado/POSCapstone/blob/master/tm1.png)

![POS Screenshot](https://github.com/tyermercado/POSCapstone/blob/master/tm2.png)


## 📜 License

This system is intended for internal or academic use. Contact the author for commercial deployment.

---


