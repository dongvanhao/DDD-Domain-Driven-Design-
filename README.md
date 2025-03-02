DDD thường chia thành 3 Layer chính:
1.	Domain Layer(tầng miền nghiệp vụ): chứa toàn bộ logic nghiệp vụ và định nghĩa các đối tượng thực tế trong hệ thống
2.	Application Layer(Tầng ứng dụng): xử lý các luồng nghiệp vụ, điều phối các thao tác từ người dùng nhưng không chứa logic nghiệp vụ
3.	Infrastructure Layer(Tầng hạ tầng): kết nối với database, Api,dịch vụ bên ngoài, giúp Domain Layer lưu trữ và truy vấn dữ liệu
   // Ngoài ra, có thể có Presentation Layer(giao diện API,Web, Mobile) nhưng không bắt buộc 
