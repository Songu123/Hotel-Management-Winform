# 📋 HƯỚNG DẪN CHỨC NĂNG UPDATE CUSTOMER

## 🎯 TỔNG QUAN

Đã triển khai đầy đủ các chức năng cập nhật thông tin khách hàng trong form `UpdateCustomerForm.cs`.

---

## 📁 CÁC FILE ĐƯỢC CHỈNH SỬA

### 1. **UpdateCustomerForm.cs** (Code Logic - Chính)
- Các method: `LoadCustomerData()`, `BtnLuuThayDoi_Click()`, `BuildAddress()`, `IsValidPhoneNumber()`
- Xử lý validation và cập nhật dữ liệu

### 2. **UCCustomer.cs** (UI - Gọi Form)
- Method: `BtnSuaKhachHang_Click()` - Uncomment và fix
- Mở form UpdateCustomerForm khi nhấn nút "Sửa khách hàng"

### 3. **UpdateCustomerForm.Designer.cs** (Tự động)
- Thêm event handler: `Load += UpdateCustomerForm_Load;`

---

## 🔧 CÁC CHỨC NĂNG CHÍNH

### 1️⃣ **LoadCustomerData()** - Load dữ liệu khách hàng
```csharp
private void LoadCustomerData()
{
    // Hiển thị mã khách hàng (readonly)
    textBox1.Text = _currentCustomer.CustomerId;
    textBox1.ReadOnly = true;

    // Load thông tin cơ bản
    txtHoTen.Text = _currentCustomer.Name;
 txtCMND.Text = _currentCustomer.IdNumber;
    dtpNgaySinh.Value = _currentCustomer.DateOfBirth;
    txtSDT.Text = _currentCustomer.PhoneNumber;

    // Load giới tính (1 = Nam, 0 = Nữ)
    rbNam.Checked = (_currentCustomer.Gender == 1);
 rbNu.Checked = (_currentCustomer.Gender == 0);

    // Parse và load địa chỉ
    ParseAndSetAddress(_currentCustomer.Address);

    // Load quốc tịch
    txtQuocTich.Text = _currentCustomer.Nationality;
}
```

**Tác dụng:**
- ✅ Populate tất cả controls trên form
- ✅ Hiển thị mã khách hàng (không cho sửa)
- ✅ Parse địa chỉ và hiển thị từng trường

---

### 2️⃣ **ParseAndSetAddress()** - Parse địa chỉ
```csharp
private void ParseAndSetAddress(string address)
{
    if (string.IsNullOrEmpty(address)) return;

    // Giả định định dạng: "Đường, Phường/Thôn, Quận/Huyện, Tỉnh/Thành"
    var parts = address.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

    if (parts.Length > 0) txtDuong.Text = parts[0].Trim();
    if (parts.Length > 1) txtPhuongThon.Text = parts[1].Trim();
    if (parts.Length > 2) txtQuanHuyen.Text = parts[2].Trim();
    if (parts.Length > 3) txtTinhThanh.Text = parts[3].Trim();
}
```

**Tác dụng:**
- ✅ Split địa chỉ thành các phần riêng lẻ
- ✅ Gán từng phần vào textbox tương ứng
- ✅ Xử lý trường hợp địa chỉ không đầy đủ

---

### 3️⃣ **BtnLuuThayDoi_Click()** - Lưu thay đổi (Async)
```csharp
private async void BtnLuuThayDoi_Click(object sender, EventArgs e)
{
    try
    {
        // Validation tên
 if (string.IsNullOrWhiteSpace(txtHoTen.Text))
  {
          MessageBox.Show("Tên khách hàng không được để trống", "Thông báo");
   txtHoTen.Focus();
      return;
   }

        // Validation số điện thoại
        if (string.IsNullOrWhiteSpace(txtSDT.Text))
   {
            MessageBox.Show("Số điện thoại không được để trống", "Thông báo");
            txtSDT.Focus();
            return;
     }

        // Validation định dạng số điện thoại
        if (!IsValidPhoneNumber(txtSDT.Text.Trim()))
        {
   MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo");
       txtSDT.Focus();
       return;
}

        // Cập nhật object
        _currentCustomer.Name = txtHoTen.Text.Trim();
        _currentCustomer.IdNumber = txtCMND.Text.Trim();
        _currentCustomer.PhoneNumber = txtSDT.Text.Trim();
        _currentCustomer.DateOfBirth = dtpNgaySinh.Value;
        _currentCustomer.Gender = rbNam.Checked ? 1 : 0;
  _currentCustomer.Address = BuildAddress();
        _currentCustomer.Nationality = txtQuocTich.Text.Trim();

        // Gọi service để cập nhật
      bool result = await _customerService.UpdateCustomerAsync(_currentCustomer);

  if (result)
        {
            MessageBox.Show("Cập nhật khách hàng thành công", "Thành công");
     this.DialogResult = DialogResult.OK;
     this.Close();
        }
        else
        {
MessageBox.Show("Cập nhật khách hàng thất bại", "Lỗi");
 }
    }
    catch (Exception ex)
    {
     MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
    }
}
```

**Tác dụng:**
- ✅ Validate dữ liệu nhập vào
- ✅ Build object Customer từ form
- ✅ Gọi service cập nhật (async)
- ✅ Xóa form khi thành công

---

### 4️⃣ **BuildAddress()** - Xây dựng chuỗi địa chỉ
```csharp
private string BuildAddress()
{
    var parts = new List<string>();

    if (!string.IsNullOrWhiteSpace(txtDuong.Text))
 parts.Add(txtDuong.Text.Trim());
    if (!string.IsNullOrWhiteSpace(txtPhuongThon.Text))
        parts.Add(txtPhuongThon.Text.Trim());
    if (!string.IsNullOrWhiteSpace(txtQuanHuyen.Text))
        parts.Add(txtQuanHuyen.Text.Trim());
    if (!string.IsNullOrWhiteSpace(txtTinhThanh.Text))
      parts.Add(txtTinhThanh.Text.Trim());

    return string.Join(", ", parts);
}
```

**Tác dụng:**
- ✅ Join các phần địa chỉ với dấu phẩy
- ✅ Loại bỏ phần trống
- ✅ Trả về chuỗi định dạng: "Đường, Phường, Quận, Tỉnh"

---

### 5️⃣ **IsValidPhoneNumber()** - Validate số điện thoại
```csharp
private bool IsValidPhoneNumber(string phoneNumber)
{
    if (string.IsNullOrWhiteSpace(phoneNumber))
   return false;

    // Độ dài từ 10-15 ký tự
    if (phoneNumber.Length < 10 || phoneNumber.Length > 15)
    return false;

    // Kiểm tra chỉ chứa chữ số hoặc các ký tự hợp lệ
    return System.Text.RegularExpressions.Regex.IsMatch(
        phoneNumber, 
     @"^[\d\s\-\+\(\)]+$"
    );
}
```

**Tác dụng:**
- ✅ Kiểm tra độ dài (10-15 ký tự)
- ✅ Kiểm tra format (chỉ số, dấu, ngoặc)
- ✅ Regex: `^[\d\s\-\+\(\)]+$`
  - `\d` = chữ số
  - `\s` = khoảng trắng
  - `\-` = dấu gạch ngang
  - `\+` = dấu cộng
  - `\(\)` = ngoặc tròn

---

## 📊 FLOW DIAGRAM

```
UCCustomer
    ↓
DgvKhachHang_SelectionChanged()  ← Chọn dòng
    ↓
_selectedCustomer = customer
    ↓
BtnSuaKhachHang_Click() ← Nhấn nút "Sửa"
    ↓
new UpdateCustomerForm(_customerService, _selectedCustomer)
    ↓
UpdateCustomerForm_Load()
    ↓
LoadCustomerData()
    ↓
ParseAndSetAddress(address)
    ↓
Form hiển thị dữ liệu ← User chỉnh sửa
    ↓
BtnLuuThayDoi_Click() ← Nhấn "Lưu thay đổi"
    ↓
Validation + BuildAddress()
    ↓
_customerService.UpdateCustomerAsync(customer)
    ↓
✅ Thành công → DialogResult.OK → Close form
❌ Thất bại → Hiển thị lỗi
```

---

## ✅ VALIDATION RULES

| Field | Rule | Message |
|-------|------|---------|
| Tên khách hàng | Không trống | "Tên khách hàng không được để trống" |
| Số điện thoại | Không trống | "Số điện thoại không được để trống" |
| Số điện thoại | Format đúng | "Số điện thoại không hợp lệ" |
| Số điện thoại | Độ dài 10-15 | "Số điện thoại không hợp lệ" |

---

## 🎯 TRƯỜNG HỢP SỬ DỤNG

### Scenario 1: Update tên khách hàng
```
1. Click vào khách hàng trong danh sách
2. Click nút "Sửa khách hàng"
3. Form UpdateCustomerForm mở
4. Chỉnh sửa txtHoTen
5. Click "Lưu thay đổi"
6. Service cập nhật → Form đóng
7. Danh sách làm mới
```

### Scenario 2: Update số điện thoại (Validation fail)
```
1. Xóa số điện thoại
2. Click "Lưu thay đổi"
3. Hiển thị lỗi: "Số điện thoại không được để trống"
4. txtSDT được focus
5. User nhập lại số điện thoại hợp lệ
```

### Scenario 3: Update địa chỉ
```
1. Form mở, nhập địa chỉ từng trường:
   - Đường: "123 Nguyễn Huệ"
   - Phường: "Bến Nghé"
   - Quận: "Quận 1"
 - Tỉnh: "TP HCM"
2. Click "Lưu thay đổi"
3. BuildAddress() join thành: "123 Nguyễn Huệ, Bến Nghé, Quận 1, TP HCM"
4. Cập nhật vào database
```

---

## 🚀 TESTING CHECKLIST

- ✅ Load dữ liệu khách hàng vào form
- ✅ Parse địa chỉ đúng từng phần
- ✅ Validation tên không trống
- ✅ Validation số điện thoại không trống
- ✅ Validation số điện thoại format
- ✅ Cập nhật customer thành công
- ✅ Khi cập nhật thành công, form đóng
- ✅ Danh sách làm mới sau cập nhật
- ✅ Mã khách hàng read-only
- ✅ Giới tính hiển thị đúng (Nam/Nữ)

---

## 📝 GHI CHÚ

1. **Address Format**: Hiện tại assume định dạng "Đường, Phường, Quận, Tỉnh"
   - Nếu thay đổi format, cần update `ParseAndSetAddress()` và `BuildAddress()`

2. **Gender Storage**: 
   - 1 = Nam (Nam radio button checked)
   - 0 = Nữ (Nữ radio button checked)

3. **Phone Validation**: Hỗ trợ format:
   - Chỉ chữ số: `0987654321`
   - Với dấu gạch: `0987-654-321`
   - Với dấu cộng: `+84987654321`
   - Với ngoặc: `(098) 7654-321`

4. **Async/Await**: `BtnLuuThayDoi_Click()` là async để không block UI khi cập nhật database

---

**Phiên bản**: 1.0  
**Ngày cập nhật**: 2024  
**Trạng thái**: ✅ Hoàn thành
