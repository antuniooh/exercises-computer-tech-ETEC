package com.example.combo;

import java.util.ArrayList;
import java.util.List;

import android.app.Activity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.app.AlertDialog;
import android.widget.*;
import android.view.*;
import android.app.*;

public class MainActivity extends Activity {
	private Spinner spnl;
	private List<String> nomes = new ArrayList<String>();
	private String nome;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		
		nomes.add("João"); //00
		nomes.add("Maria");//01
		nomes.add("José");//02
		nomes.add("Paulo");//03
		nomes.add("Adriana");//04
		
		spnl = (Spinner) findViewById(R.id.spinner1);
		
		//adaptar as informações em listas
		ArrayAdapter <String> arrayAdapter = new ArrayAdapter<String>(this, android.R.layout.simple_spinner_dropdown_item,nomes);
		ArrayAdapter <String> spinnerArrayAdapter = arrayAdapter;
		spinnerArrayAdapter.setDropDownViewResource(android.R.layout.simple_spinner_item);
		spnl.setAdapter(spinnerArrayAdapter);
		
		//captura do item selecionado
		spnl.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener(){
			
			public void onItemSelected(AdapterView<?> parent, View v, int posicao, long id){
				//verifica a posição
				nome = parent.getItemAtPosition(posicao).toString();
				//imprime o resultado na tela
				Toast.makeText(MainActivity.this, "Nome selecionado: " + nome, Toast.LENGTH_LONG).show();
			}	
			public void onNothingSelected(AdapterView<?> parent){
				
			}
		});
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.main, menu);
		return true;
	}

	@Override
	public boolean onOptionsItemSelected(MenuItem item) {
		// Handle action bar item clicks here. The action bar will
		// automatically handle clicks on the Home/Up button, so long
		// as you specify a parent activity in AndroidManifest.xml.
		int id = item.getItemId();
		if (id == R.id.action_settings) {
			return true;
		}
		return super.onOptionsItemSelected(item);
	}
}
