package com.asincro.donator.donator.Database;

import android.graphics.Bitmap;

/**
 * Created by Andro on 22.11.2014..
 */
public class Institution {

    private int productId;
    private String name;
    private String address;
    private String photo;
    private Bitmap bitmap;

    public Institution(int productId, String name, String address, String photo, Bitmap bitmap) {
        this.productId = productId;
        this.name = name;
        this.address = address;
        this.photo = photo;
        this.bitmap = bitmap;
    }

    public Bitmap getBitmap() {
        return bitmap;
    }

    public void setBitmap(Bitmap bitmap) {
        this.bitmap = bitmap;
    }

    public int getProductId() {
        return productId;
    }

    public void setProductId(int productId) {
        this.productId = productId;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getAddress() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    public String getPhoto() {
        return photo;
    }

    public void setPhoto(String photo) {
        this.photo = photo;
    }
}
