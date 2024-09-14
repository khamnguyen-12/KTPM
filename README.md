# KIỂM THỬ PHẦN MỀM TÍNH CHỈ SỐ BMI VÀ KIỂM THỬ TỰ ĐỘNG ỨNG DỤNG WEB
TỔNG QUAN DỰ ÁN

Dự án này tập trung vào việc phát triển và kiểm thử một ứng dụng với ba thành phần chính: ứng dụng Windows Forms để tính toán chỉ số BMI, kiểm thử tự động các chức năng của ứng dụng web bằng Selenium, và kiểm thử API bằng Postman.

## Mục Lục
1. [Ứng Dụng Tính Toán BMI](#ứng-dụng-tính-toán-bmi)
2. [Kiểm Thử Tự Động Ứng Dụng Web](#kiểm-thử-tự-động-ứng-dụng-web)
3. [Kiểm Thử API với Postman](#kiểm-thử-api-với-postman)
4. [Công Nghệ Sử Dụng](#công-nghệ-sử-dụng)

---

## 1. Ứng Dụng Tính Toán BMI
- **Mục tiêu:** Xây dựng một ứng dụng Windows Forms sử dụng .NET Framework để tính toán chỉ số BMI (Body Mass Index) dựa trên chiều cao và cân nặng của người dùng.
- **Chức năng chính:**
  - Tính toán BMI: Phương thức `CalculateBMI_79_Kham` trong lớp `CaculationBMI_79_NguyenVietKham` sẽ tính chỉ số BMI và phân loại kết quả vào các nhóm: gầy, bình thường, thừa cân, béo.
  - Kiểm thử đơn vị: Sử dụng NUnit để viết và chạy các test case kiểm thử các tình huống khác nhau và xác minh tính chính xác của phép tính BMI.

## 2. Kiểm Thử Tự Động Ứng Dụng Web
- **Mục tiêu:** Sử dụng Selenium WebDriver để kiểm thử tự động các chức năng của ứng dụng web, bao gồm việc đăng bài và tìm kiếm ảnh.
- **Chức năng chính:**
  - Tạo môi trường kiểm thử: Cài đặt các thư viện Selenium và thiết lập môi trường kiểm thử.
  - Viết kiểm thử tự động: Phát triển và thực hiện các kiểm thử tự động cho chức năng đăng bài và tìm kiếm ảnh, đảm bảo các chức năng này hoạt động chính xác.

## 3. Kiểm Thử API với Postman
- **Mục tiêu:** Kiểm thử các API sử dụng Postman và JSONServer để xác thực các hoạt động của API như GET, POST, DELETE, và PUT.
- **Chức năng chính:**
  - Cài đặt JSONServer: Cấu hình JSONServer để tạo một server ảo cho việc kiểm thử API.
  - Viết test scripts trong Postman: Tạo và thực hiện các script kiểm thử cho các loại yêu cầu API, đảm bảo các API hoạt động như mong đợi.

## 4. Công Nghệ Sử Dụng
- **Ngôn ngữ lập trình:** C#, JavaScript (dùng cho Selenium), JSON (cho API với JSONServer)
- **Frameworks:** .NET Framework (cho ứng dụng Windows Forms App), NUnit (cho Unit Test), Selenium WebDriver (kiểm thử tự động)
- **Công cụ và môi trường phát triển:** Visual Studio, NuGet Package Manager, Postman, JSONServer
- **Thư viện:** Selenium (kiểm thử trình duyệt), System.Data (xử lý dữ liệu cho kiểm thử)
- **Cơ sở dữ liệu:** CSV (lưu trữ dữ liệu kiểm thử cho Unit Test)
