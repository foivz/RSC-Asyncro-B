package com.asincro.donator.donator.Fragment;

import android.app.Activity;
import android.app.Fragment;
import android.app.ListFragment;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import com.asincro.donator.donator.Database.Institution;
import com.asincro.donator.donator.MainActivity;
import com.asincro.donator.donator.R;

/**
 * Created by Andro on 22.11.2014..
 */
public class InstitutionListFragment extends ListFragment {

    Institution[] institutions;

    /**
     * The fragment argument representing the section number for this
     * fragment.
     */
    private static final String ARG_SECTION_NUMBER = "section_number";

    /**
     * Returns a new instance of this fragment for the given section
     * number.
     */
    public static InstitutionListFragment newInstance(int sectionNumber) {
        InstitutionListFragment fragment = new InstitutionListFragment();
        Bundle args = new Bundle();
        args.putInt(ARG_SECTION_NUMBER, sectionNumber);
        fragment.setArguments(args);
        return fragment;
    }

    public InstitutionListFragment() {
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        View rootView = inflater.inflate(R.layout.fragment_institution_list, container, false);
        return rootView;
    }

    @Override
    public void onAttach(Activity activity) {
        super.onAttach(activity);
        ((MainActivity) activity).onSectionAttached(
                getArguments().getInt(ARG_SECTION_NUMBER));
    }

    @Override
    public void onActivityCreated(Bundle savedInstanceState) {
        super.onActivityCreated(savedInstanceState);
        //Institution instance = new Institution(1, "Bolnica", "Adresa", "Slika", R.drawable.bolnica);
    }
}
