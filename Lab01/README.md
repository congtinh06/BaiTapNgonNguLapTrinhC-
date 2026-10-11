# BaiTapNNLTCSharp

Đây là kho lưu trữ bài tập môn **Ngôn ngữ lập trình C#**, tổng hợp toàn bộ các bài thực hành được thực hiện trong suốt học kỳ. Mỗi buổi học tương ứng với một thư mục riêng, bao gồm phần bài tập cơ bản, bài tập nâng cao và các bộ kiểm thử (Unit Test) đi kèm.

Mục tiêu của repo là giúp nhóm lưu trữ, theo dõi tiến độ làm bài và làm việc nhóm thuận tiện thông qua Git và GitHub trong suốt quá trình học.

---

## Thông tin nhóm

| STT | Họ và tên | MSSV |
|---|---|---|
| 1 | Đặng Hữu Đăng Tâm | 3124411265 |
| 2 | Đặng Đào Đạt Thành | 3124411274 |
| 3 | Huỳnh Công Tính | 3124411315 |

---

## Cấu trúc thư mục

Repo được tổ chức theo từng buổi học (Buoi01 đến Buoi12). Bên trong mỗi buổi thường có hai nhóm bài tập:

- **BaiTapCoBan**: các bài tập cơ bản, rèn luyện cú pháp và tư duy lập trình nền tảng của C#.
- **BaiTapNangCao**: các bài tập nâng cao hơn, áp dụng các kiến thức mở rộng như lập trình hướng đối tượng, xử lý ngoại lệ, thu thập dữ liệu, v.v.

Mỗi bài tập đều là một project C# độc lập (tệp `.csproj` riêng), đi kèm một project kiểm thử tương ứng có hậu tố `Test` (ví dụ: `Bai1_InNhan` đi cùng `Bai1_InNhanTest`), sử dụng xUnit để viết các trường hợp kiểm thử.

Cấu trúc tổng quát như sau:

```
BaiTapNNLTCSharp/
├── Buoi01/
│   ├── Buoi1_BaiTapCoBan/
│   │   ├── Bai1_InNhan/
│   │   ├── Bai1_InNhanTest/
│   │   ├── BT02/
│   │   ├── BT02Test/
│   │   └── ...
│   └── Buoi1_BaiTapNangCao/
├── Buoi02/
├── ...
├── Buoi12/
├── .gitignore
└── NNLTC#.sln
```

Toàn bộ solution được quản lý chung trong một tệp `.sln` duy nhất, cho phép build và chạy tất cả các project cùng lúc hoặc từng project riêng lẻ.

---

## Công nghệ và công cụ sử dụng

- Ngôn ngữ lập trình: C#
- Nền tảng: .NET 10.0
- Framework kiểm thử: xUnit
- Quản lý mã nguồn: Git và GitHub
- Môi trường phát triển khuyến nghị: Visual Studio 2022 hoặc Visual Studio Code

---

## Hướng dẫn sử dụng

**Sao chép repo về máy:**

```
git clone https://github.com/congtinh06/BaiTapNNLTCSharp.git
cd BaiTapNNLTCSharp
```

**Build toàn bộ solution:**

```
dotnet build
```

**Chạy một bài tập cụ thể:**

```
cd Buoi01/Buoi1_BaiTapCoBan/Bai1_InNhan
dotnet run
```

**Chạy toàn bộ Unit Test:**

```
dotnet test
```

---

## Quy trình làm việc nhóm

Các thành viên làm việc trên cùng một nhánh chính (`main`). Trước khi bắt đầu chỉnh sửa, nên chạy `git pull` để cập nhật code mới nhất, tránh xung đột khi merge. Sau khi hoàn thành một phần bài tập, thực hiện `commit` với nội dung mô tả rõ ràng rồi `push` lên GitHub để các thành viên khác có thể theo dõi tiến độ.

---

## Ghi chú

Repo này được lập ra nhằm mục đích học tập, phục vụ cho việc nộp bài và theo dõi quá trình thực hành trong môn Ngôn ngữ lập trình C#.
