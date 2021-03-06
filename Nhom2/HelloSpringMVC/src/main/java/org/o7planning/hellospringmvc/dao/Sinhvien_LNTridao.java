package org.o7planning.hellospringmvc.dao;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;

import org.o7planning.hellospringmvc.bean.SinhVien_LNTribean;

public class Sinhvien_LNTridao {

	
		public ArrayList<SinhVien_LNTribean> getsinhvien() throws Exception{
			ArrayList<SinhVien_LNTribean> ds=new ArrayList<SinhVien_LNTribean>();
			
			//B1: kết nối
			DungChung dc = new DungChung();
			dc.KetNoi();
			//b2: lay du lieu ve
			String sql = "Select * from SinhVien";
			PreparedStatement cmd = dc.cn.prepareStatement(sql);
			ResultSet rs = cmd.executeQuery();
			//b3: duyet qua cac du lieu lay ve de luu vao 1 mang
			while(rs.next()) {
				String Masv=rs.getString("Masv");
	    		String HoTen=rs.getString("HoTen");
	    		String DiaChi=rs.getString("DiaChi");
	    		long DTB=rs.getLong("DTB");
	    		ds.add(new SinhVien_LNTribean(Masv, DiaChi,HoTen,DTB));
	    		
	    	}
			//Dong ket noi
	    	rs.close();
	    	dc.cn.close();
	    	return ds;
		}
}

