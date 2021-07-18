package com.example.notas_do_aluno;

import android.app.Activity;
import android.app.AlertDialog;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.*;
import android.view.*;
import android.app.*;

public class MainActivity extends Activity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		
		Button btnCalcular = (Button) findViewById(R.id.btnCalcular);
		btnCalcular.setOnClickListener(new View.OnClickListener() {
			
			
			@Override
			public void onClick(View arg0) {
				double nota1,nota2,nota3,nota4,média;
				EditText txt1bimestre = (EditText) findViewById(R.id.txt1bimestre);
				EditText txt2bimestre = (EditText) findViewById(R.id.txt2bimestre);
				EditText txt3bimestre = (EditText) findViewById(R.id.EditText02);
				EditText txt4bimestre = (EditText) findViewById(R.id.txt4bimestre);
				nota1 = Double.parseDouble(txt1bimestre.getText().toString());
				nota2 = Double.parseDouble(txt2bimestre.getText().toString());
				nota3 = Double.parseDouble(txt3bimestre.getText().toString());
				nota4 = Double.parseDouble(txt4bimestre.getText().toString());
				
				Button btnCalcular = (Button) findViewById(R.id.btnCalcular);
				
				média = (nota1 + nota2 + nota3 + nota4)/4;
			
				AlertDialog.Builder dialogo = new AlertDialog.Builder(MainActivity.this);
				dialogo.setTitle("Média");
				dialogo.setMessage("Sua média é: " + String.valueOf(média));
				dialogo.setNeutralButton("OK",null);
				dialogo.show();
				
				
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
