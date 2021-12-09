package org.o7planning.hellospringmvc.bean;

public class SinhVien_LNTribean {
	private String Masv;
	private String HoTen;
	private String Diachi;
	private long DTB;
	public SinhVien_LNTribean() {
		super();
		// TODO Auto-generated constructor stub
	}
	public SinhVien_LNTribean(String Masv, String HoTen, String Diachi, long DTB) {
		super();
		this.Masv = Masv;
		this.HoTen = HoTen;
		this.Diachi = Diachi;
		this.DTB = DTB;
	}
	public String getMasv() {
		return Masv;
	}
	public void setMasv(String masv) {
		Masv = masv;
	}
	public String getHoTen() {
		return HoTen;
	}
	public void setHoTen(String hoTen) {
		HoTen = hoTen;
	}
	public String getDiachi() {
		return Diachi;
	}
	public void setDiachi(String diachi) {
		Diachi = diachi;
	}
	public float getDTB() {
		return DTB;
	}
	public void setDTB(long dTB) {
		DTB = dTB;
	}
}
