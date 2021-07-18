package com.example.salario;

import com.example.salario.MainActivity;
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
			
			private Object op;

			@Override
			public void onClick(View arg0) {
				double salario,novo_sal;
				EditText edsalario = (EditText) findViewById(R.id.edSalario);
				salario = Double.parseDouble(edsalario.getText().toString());
				RadioGroup rg = (RadioGroup) findViewById(R.id.rgopcoes);
				
				if(op == R.id.rb40)
				novo_sal = salario + (salario *0.4);
				else if(op == R.id.rb45)
				novo_sal = salario + (salario *0.45);
				else
				novo_sal = salario + (salario *0.5);
				
				AlertDialog.Builder dialogo = new AlertDialog.Builder(MainActivity.this);
				dialogo.setTitle("Novo Salário");
				dialogo.setMessage("Seu novo salário é: " + String.valueOf(novo_sal));
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
