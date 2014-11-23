package com.asincro.donator.donator.Adapter;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import com.asincro.donator.donator.Database.Institution;
import com.asincro.donator.donator.R;

/**
 * Created by Andro on 22.11.2014..
 */
public class InstitutionListAdapter extends ArrayAdapter<Institution> {
    private final Context context;
    private final Institution[] values;

    public InstitutionListAdapter(Context context, Institution[] values) {
        super(context, R.layout.fragment_institution_list, values);
        this.context = context;
        this.values = values;
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        LayoutInflater inflater = (LayoutInflater) context
                .getSystemService(Context.LAYOUT_INFLATER_SERVICE);
        View rowView = inflater.inflate(R.layout.list_institution, parent, false);

        ImageView image = (ImageView)rowView.findViewById(R.id.image_institution_thumbnail);
        image.setImageBitmap(values[position].getBitmap());

        TextView title = (TextView) rowView.findViewById(R.id.text_institution_title);
        title.setText(values[position].getName());

        TextView address = (TextView) rowView.findViewById(R.id.text_institution_address);
        address.setText(values[position].getAddress());

        return rowView;
    }
}
