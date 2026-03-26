# ⚡ QUICK REFERENCE - UPDATE CUSTOMER FEATURE

## 🎯 TÓM TẮT

Đã triển khai **chức năng cập nhật thông tin khách hàng** với đầy đủ validation và error handling.

---

## 📂 FILES CHÍNH

```
📦 QuanLyKhachSan/UI/CustomerUI/
├── 📄 UpdateCustomerForm.cs          ← CODE LOGIC (Chính)
├── 📄 UpdateCustomerForm.Designer.cs ← UI (Tự động)
├── 📄 UCCustomer.cs              ← GỌI FORM (Sửa)
└── 📄 UpdateCustomerForm.resx        ← RESOURCES
```

---

## 🔑 FUNCTIONS

### LoadCustomerData()
**Mục đích**: Load dữ liệu khách hàng vào form  
**When**: Khi form được load (Form_Load event)  
**Returns**: void

```csharp
private void LoadCustomerData()
{
    // Hiển thị: Mã KH, Tên, CMND, Sinh nhật, SDT, Giới tính, Địa chỉ, Quốc tịch
}
```

---

### BtnLuuThayDoi_Click()
**Mục đích**: Validate, save, update database  
**When**: User click "Lưu thay đổi"  
**Async**: YES

**Flow**:
1. Validate tên (bắt buộc)
2. Validate SDT (bắt buộc)
3. Validate format SDT (10-15 ký tự)
4. Build address
5. Update customer object
6. Call `_customerService.UpdateCustomerAsync()`
7. Close form if success

---

### ParseAndSetAddress()
**Mục đích**: Parse địa chỉ → Split thành các field  
**Input**: `string address`  
**Format**: "Đường, Phường, Quận, Tỉnh"

---

### BuildAddress()
**Mục đích**: Merge các field → Build chuỗi địa chỉ  
**Output**: `"Đường, Phường, Quận, Tỉnh"`

---

### IsValidPhoneNumber()
**Mục đích**: Validate số điện thoại  
**Input**: `string phoneNumber`  
**Returns**: `bool`  
**Checks**:
- Độ dài 10-15
- Chỉ chữ số, `-`, `+`, `()`, space

---

## ✅ CHECKLIST

- [x] Constructor có injection ICustomerService
- [x] Form_Load event gắn
- [x] LoadCustomerData() hoạt động
- [x] ParseAndSetAddress() hoạt động
- [x] BtnLuuThayDoi_Click() validation
- [x] BuildAddress() hoạt động
- [x] IsValidPhoneNumber() hoạt động
- [x] UCCustomer.BtnSuaKhachHang_Click() uncomment & fix
- [x] Event handlers gắn
- [x] Build success (0 errors)

---

## 🔍 USAGE

### Mở form sửa khách hàng:
```csharp
var customer = selectedCustomer; // Khách hàng được chọn
var form = new UpdateCustomerForm(_customerService, customer);
form.ShowDialog(); // Mở modal
```

### Trong UCCustomer.cs:
```csharp
// Khi user click "Sửa khách hàng"
var updateForm = new UpdateCustomerForm(_customerService, _selectedCustomer);
if (updateForm.ShowDialog() == DialogResult.OK)
{
    // Reload danh sách
    await LoadCustomersAsync();
}
```

---

## 🚨 ERROR HANDLING

| Scenario | Error Message | Action |
|----------|---------------|--------|
| Tên trống | "Tên khách hàng không được để trống" | Focus txtHoTen |
| SDT trống | "Số điện thoại không được để trống" | Focus txtSDT |
| SDT sai format | "Số điện thoại không hợp lệ" | Focus txtSDT |
| Service exception | $"Lỗi: {ex.Message}" | MessageBox |
| Update fail | "Cập nhật khách hàng thất bại" | Form stay open |
| Update success | "Cập nhật khách hàng thành công" | Close form |

---

## 🧪 TEST CASES

```
✓ TC1: Load data khách hàng         → Fields populated
✓ TC2: Parse địa chỉ   → Address split correctly
✓ TC3: Validate tên trống   → Error message
✓ TC4: Validate SDT trống                  → Error message
✓ TC5: Validate SDT format (< 10)  → Error message
✓ TC6: Validate SDT format (> 15)      → Error message
✓ TC7: Validate SDT format (invalid char)  → Error message
✓ TC8: Update data success            → Form closed, list refreshed
✓ TC9: Close button         → Form closed, no save
✓ TC10: Gender selection (Nam/Nữ)      → Correct gender value
```

---

## 📊 DATA MAPPING

| UI Field | Model Property | Format |
|----------|----------------|--------|
| textBox1 | CustomerId | string (readonly) |
| txtHoTen | Name | string (required) |
| txtCMND | IdNumber | string |
| dtpNgaySinh | DateOfBirth | DateTime |
| txtSDT | PhoneNumber | string (required, validate) |
| rbNam/rbNu | Gender | int (1=Nam, 0=Nữ) |
| txtDuong+ | Address | string (parsed/built) |
| txtQuocTich | Nationality | string |

---

## 🔗 DEPENDENCIES

```
UpdateCustomerForm
  └── ICustomerService (injected)
      └── UpdateCustomerAsync()

UCCustomer
  └── BtnSuaKhachHang_Click()
      └── new UpdateCustomerForm()
          └── ShowDialog()
```

---

## 📝 COMMON MODIFICATIONS

### Change address format from "A, B, C, D" to "A|B|C|D":
```csharp
// ParseAndSetAddress()
var parts = address.Split(new[] { '|' }, ...);

// BuildAddress()
return string.Join("|", parts);
```

### Add more fields (e.g., Email):
```csharp
// LoadCustomerData()
txtEmail.Text = _currentCustomer.Email;

// BuildCustomer() / Save
_currentCustomer.Email = txtEmail.Text.Trim();
```

### Add custom validation:
```csharp
// BtnLuuThayDoi_Click()
if (!IsValidEmail(txtEmail.Text))
{
    MessageBox.Show("Email không hợp lệ");
    txtEmail.Focus();
    return;
}
```

---

## 🎓 LEARNING POINTS

1. **Async/Await**: Sử dụng async để không block UI khi save database
2. **Validation**: Always validate trước khi save
3. **Dependency Injection**: Service được inject, không new
4. **Dialog Result**: DialogResult.OK/Cancel để biết user save hay cancel
5. **Regex**: Sử dụng regex để validate complex pattern
6. **Parsing**: Cần parse dữ liệu khác định dạng lưu trữ (address)

---

## 🏁 STATUS

```
✅ COMPLETE - Ready for production
   - All functions implemented
   - All validation added
   - All error handling done
   - All tests passed
```

---

**Last Updated**: 2024  
**Version**: 1.0  
**Author**: Development Team
