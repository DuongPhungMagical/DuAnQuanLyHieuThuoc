using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DuAnQuanLyHieuThuoc.Models;

public partial class DataContext : DbContext
{
    public DataContext()
    {
    }

    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BaoCaoDoanhThu> BaoCaoDoanhThus { get; set; }

    public virtual DbSet<ChiTietNhapKho> ChiTietNhapKhos { get; set; }

    public virtual DbSet<HangSanXuat> HangSanXuats { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<LoaiThuoc> LoaiThuocs { get; set; }

    public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<NhapKho> NhapKhos { get; set; }

    public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

    public virtual DbSet<Thuoc> Thuocs { get; set; }

    public virtual DbSet<TrangThai> TrangThais { get; set; }

    public virtual DbSet<VaiTro> VaiTros { get; set; }

    public virtual DbSet<Voucher> Vouchers { get; set; }

    public virtual DbSet<VoucherHoaDon> VoucherHoaDons { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DUONGSOFM;Database=DuAnQuanLyHieuThuoc;Trusted_Connection=True; TrustServerCertificate =True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BaoCaoDoanhThu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BaoCaoDo__3214EC07F65BBDDC");

            entity.ToTable("BaoCaoDoanhThu");

            entity.Property(e => e.NgayBatDau).HasColumnType("datetime");
            entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");
        });

        modelBuilder.Entity<ChiTietNhapKho>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ChiTietN__3214EC07BE1CAF6B");

            entity.ToTable("ChiTietNhapKho");

            entity.Property(e => e.NgayNhap).HasColumnType("datetime");

            entity.HasOne(d => d.IdNhapKhoNavigation).WithMany(p => p.ChiTietNhapKhos)
                .HasForeignKey(d => d.IdNhapKho)
                .HasConstraintName("FK__ChiTietNh__IdNha__59FA5E80");

            entity.HasOne(d => d.IdThuocNavigation).WithMany(p => p.ChiTietNhapKhos)
                .HasForeignKey(d => d.IdThuoc)
                .HasConstraintName("FK__ChiTietNh__IdThu__59063A47");
        });

        modelBuilder.Entity<HangSanXuat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HangSanX__3214EC07BF83BBDB");

            entity.ToTable("HangSanXuat");

            entity.Property(e => e.DiaChi).HasMaxLength(50);
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TenHangSanXuat).HasMaxLength(50);
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HoaDon__3214EC07A1D4E6F7");

            entity.ToTable("HoaDon");

            entity.Property(e => e.HinhThucThanhToan).HasMaxLength(50);
            entity.Property(e => e.NgayLap).HasColumnType("datetime");
            entity.Property(e => e.TrangThai).HasMaxLength(50);

            entity.HasOne(d => d.IdKhachHangNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.IdKhachHang)
                .HasConstraintName("FK__HoaDon__IdKhachH__4E88ABD4");

            entity.HasOne(d => d.IdNhanVienNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.IdNhanVien)
                .HasConstraintName("FK__HoaDon__IdNhanVi__4D94879B");
        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HoaDonCh__3214EC076EB5CDBA");

            entity.ToTable("HoaDonChiTiet");

            entity.Property(e => e.GhiChu).HasMaxLength(50);

            entity.HasOne(d => d.IdHoaDonNavigation).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.IdHoaDon)
                .HasConstraintName("FK__HoaDonChi__IdHoa__5165187F");

            entity.HasOne(d => d.IdThuocNavigation).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.IdThuoc)
                .HasConstraintName("FK__HoaDonChi__IdThu__52593CB8");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__KhachHan__3214EC07A854A36D");

            entity.ToTable("KhachHang");

            entity.Property(e => e.DiaChi).HasMaxLength(50);
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TenKhachHang).HasMaxLength(50);
        });

        modelBuilder.Entity<LoaiThuoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LoaiThuo__3214EC071BCDE6F0");

            entity.ToTable("LoaiThuoc");

            entity.Property(e => e.TenLoaiThuoc).HasMaxLength(50);
        });

        modelBuilder.Entity<NhaCungCap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NhaCungC__3214EC075067AF8C");

            entity.ToTable("NhaCungCap");

            entity.Property(e => e.DiaChi).HasMaxLength(50);
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TenNhaCungCap).HasMaxLength(50);
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NhanVien__3214EC073FBF9DD6");

            entity.ToTable("NhanVien");

            entity.Property(e => e.DiaChi).HasMaxLength(50);
            entity.Property(e => e.NgayVaoLam).HasColumnType("datetime");
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TenNhanVien).HasMaxLength(50);

            entity.HasOne(d => d.IdTrangThaiNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.IdTrangThai)
                .HasConstraintName("FK__NhanVien__IdTran__70DDC3D8");
        });

        modelBuilder.Entity<NhapKho>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NhapKho__3214EC07A9589040");

            entity.ToTable("NhapKho");

            entity.Property(e => e.NgayNhap).HasColumnType("datetime");

            entity.HasOne(d => d.IdNhaCungCapNavigation).WithMany(p => p.NhapKhos)
                .HasForeignKey(d => d.IdNhaCungCap)
                .HasConstraintName("FK__NhapKho__IdNhaCu__5629CD9C");

            entity.HasOne(d => d.IdNhanVienNavigation).WithMany(p => p.NhapKhos)
                .HasForeignKey(d => d.IdNhanVien)
                .HasConstraintName("FK__NhapKho__IdNhanV__5535A963");
        });

        modelBuilder.Entity<TaiKhoan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaiKhoan__3214EC07E29F4688");

            entity.ToTable("TaiKhoan");

            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.MatKhau)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TenTaiKhoan)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TrangThai)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.VaiTro)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.IdNhanVienNavigation).WithMany(p => p.TaiKhoans)
                .HasForeignKey(d => d.IdNhanVien)
                .HasConstraintName("FK__TaiKhoan__IdNhan__5AEE82B9");
        });

        modelBuilder.Entity<Thuoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Thuoc__3214EC07C883652B");

            entity.ToTable("Thuoc");

            entity.Property(e => e.DonViTinh).HasMaxLength(50);
            entity.Property(e => e.HanSuDung).HasColumnType("datetime");
            entity.Property(e => e.MoTa).HasMaxLength(50);
            entity.Property(e => e.TenThuoc).HasMaxLength(50);

            entity.HasOne(d => d.IdHangSanXuatNavigation).WithMany(p => p.Thuocs)
                .HasForeignKey(d => d.IdHangSanXuat)
                .HasConstraintName("FK__Thuoc__IdHangSan__3C69FB99");

            entity.HasOne(d => d.IdLoaiThuocNavigation).WithMany(p => p.Thuocs)
                .HasForeignKey(d => d.IdLoaiThuoc)
                .HasConstraintName("FK__Thuoc__IdLoaiThu__3B75D760");

            entity.HasOne(d => d.IdNhaCungCapNavigation).WithMany(p => p.Thuocs)
                .HasForeignKey(d => d.IdNhaCungCap)
                .HasConstraintName("FK__Thuoc__IdNhaCung__4AB81AF0");
        });

        modelBuilder.Entity<TrangThai>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TrangTha__3214EC07B6CCEA4E");

            entity.ToTable("TrangThai");

            entity.Property(e => e.TrangThai1)
                .HasMaxLength(30)
                .HasColumnName("TrangThai");
        });

        modelBuilder.Entity<VaiTro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VaiTro__3214EC0766481C7B");

            entity.ToTable("VaiTro");

            entity.Property(e => e.MoTa).HasMaxLength(50);
            entity.Property(e => e.VaiTro1)
                .HasMaxLength(50)
                .HasColumnName("VaiTro");
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Voucher__3214EC077250E934");

            entity.ToTable("Voucher");

            entity.Property(e => e.NgayBatDau).HasColumnType("datetime");
            entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");
            entity.Property(e => e.PhanTramGiam).HasColumnType("decimal(4, 2)");
            entity.Property(e => e.TenVoucher).HasMaxLength(50);
        });

        modelBuilder.Entity<VoucherHoaDon>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VoucherHoaDon");

            entity.HasOne(d => d.IdHoaDonNavigation).WithMany()
                .HasForeignKey(d => d.IdHoaDon)
                .HasConstraintName("FK__VoucherHo__IdHoa__628FA481");

            entity.HasOne(d => d.IdVoucherNavigation).WithMany()
                .HasForeignKey(d => d.IdVoucher)
                .HasConstraintName("FK__VoucherHo__IdVou__6383C8BA");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
