package com.example.teste_bim;

import android.app.Activity;
import android.app.AlertDialog;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.*;
import android.app.*;
import android.widget.*;
import android.widget.AdapterView.OnItemClickListener;
import android.view.*;

public class MainActivity extends Activity {

	Button bttelaprincipal, bttela2;
	public ListView list;
	String times[]={"Corinthiasn","São Paulo", "Palmeiras","Botafogo","Santos"};
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		CarregarTelaPrincipal();
	
		Button btnCalcular = (Button) findViewById(R.id.btnCalcular);
		btnCalcular.setOnClickListener(new View.OnClickListener() {
		
		@Override
		public void onClick(View arg0) {
			double valor1,valor2,soma;
			EditText txt1 = (EditText) findViewById(R.id.textV1);
			EditText txt2 = (EditText) findViewById(R.id.textV2);
			
			valor1 = Double.parseDouble(txt1.getText().toString());
			valor2 = Double.parseDouble(txt2.getText().toString());
			
			Button btnCalcular = (Button) findViewById(R.id.btnCalcular);
			
			soma = (valor1 + valor2);
			
			AlertDialog.Builder dialogo = new AlertDialog.Builder(MainActivity.this);
			dialogo.setTitle("Soma");
			dialogo.setMessage("Sua soma é: " + String.valueOf(soma));
			dialogo.setNeutralButton("OK",null);
			dialogo.show();
		}});
						
		/*ArrayAdapter<String> adapter= new ArrayAdapter<String>(this,
				android.R.layout.simple_list_item_1, times);
		list = (ListView) findViewById(R.id.list);
		list.setAdapter(adapter);
		
		list.setOnItemClickListener(new OnItemClickListener(){
			public void onItemClick(AdapterView parent, View view,
					int position, long id) {
				AlertDialog.Builder mensagem = new AlertDialog.Builder (
					MainActivity.this);
		mensagem.setTitle("Atenção, você escolheu: ");
		mensagem.setMessage(((TextView) view).getText().toString());
		mensagem.setNeutralButton("OK", null);
		mensagem.show();
			}
		});*/
}

	public void CarregarTelaPrincipal()
	{
		setContentView(R.layout.activity_main);
		bttela2 = (Button) findViewById(R.id.bttela2);
		bttela2.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				CarregarTela2();				
			}
		});
	}
	
	public void CarregarTela2()
	{
		setContentView(R.layout.activity_two);
		bttelaprincipal = (Button) findViewById(R.id.bttelaprincipal);
		bttelaprincipal.setOnClickListener(new View.OnClickListener() {
	
			@Override
			public void onClick(View v) {
				CarregarTelaPrincipal();				
			}
		});
	}
			
	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
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
