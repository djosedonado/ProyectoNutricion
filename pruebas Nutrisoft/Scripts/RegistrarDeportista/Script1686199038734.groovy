import static com.kms.katalon.core.checkpoint.CheckpointFactory.findCheckpoint
import static com.kms.katalon.core.testcase.TestCaseFactory.findTestCase
import static com.kms.katalon.core.testdata.TestDataFactory.findTestData
import static com.kms.katalon.core.testobject.ObjectRepository.findTestObject
import static com.kms.katalon.core.testobject.ObjectRepository.findWindowsObject
import com.kms.katalon.core.checkpoint.Checkpoint as Checkpoint
import com.kms.katalon.core.cucumber.keyword.CucumberBuiltinKeywords as CucumberKW
import com.kms.katalon.core.mobile.keyword.MobileBuiltInKeywords as Mobile
import com.kms.katalon.core.model.FailureHandling as FailureHandling
import com.kms.katalon.core.testcase.TestCase as TestCase
import com.kms.katalon.core.testdata.TestData as TestData
import com.kms.katalon.core.testng.keyword.TestNGBuiltinKeywords as TestNGKW
import com.kms.katalon.core.testobject.TestObject as TestObject
import com.kms.katalon.core.webservice.keyword.WSBuiltInKeywords as WS
import com.kms.katalon.core.webui.keyword.WebUiBuiltInKeywords as WebUI
import com.kms.katalon.core.windows.keyword.WindowsBuiltinKeywords as Windows
import internal.GlobalVariable as GlobalVariable
import org.openqa.selenium.Keys as Keys

Windows.startApplicationWithTitle('C:\\Users\\danil\\source\\repos\\ProyectoNutricion\\Presentacion\\bin\\Debug\\Presentacion.exe', 
    'Form1')

Windows.click(findWindowsObject('Object Repository/Vnculo'))

Windows.click(findWindowsObject('Object Repository/CuadroCombinado'))

Windows.click(findWindowsObject('Object Repository/ElementoDeLista'))

Windows.click(findWindowsObject('Object Repository/Editar'))

Windows.setText(findWindowsObject('Object Repository/Editar'), '1063600372')

Windows.click(findWindowsObject('Object Repository/Editar(1)'))

Windows.setText(findWindowsObject('Object Repository/Editar(1)'), 'danilo jose')

Windows.click(findWindowsObject('Object Repository/Editar(2)'))

Windows.setText(findWindowsObject('Object Repository/Editar(2)'), 'donado sandoval')

Windows.click(findWindowsObject('Object Repository/Editar(3)'))

Windows.setText(findWindowsObject('Object Repository/Editar(3)'), '316047782')

Windows.click(findWindowsObject('Object Repository/Botn'))

Windows.click(findWindowsObject('Object Repository/ElementoDeLista(1)'))

Windows.click(findWindowsObject('Object Repository/Editar(4)'))

Windows.setText(findWindowsObject('Object Repository/Editar(4)'), 'danilo@gmail.com')

Windows.click(findWindowsObject('Object Repository/Editar(4)'))

Windows.setText(findWindowsObject('Object Repository/Editar(4)'), 'danilo23@gmail.com')

Windows.click(findWindowsObject('Object Repository/Editar(5)'))

Windows.click(findWindowsObject('Object Repository/Panel'))

Windows.click(findWindowsObject('Object Repository/Panel'))

Windows.click(findWindowsObject('Object Repository/Panel'))

Windows.click(findWindowsObject('Object Repository/Elemento'))

Windows.click(findWindowsObject('Object Repository/Elemento(1)'))

Windows.click(findWindowsObject('Object Repository/Elemento(2)'))

Windows.click(findWindowsObject('Object Repository/Elemento(3)'))

Windows.click(findWindowsObject('Object Repository/Elemento(4)'))

Windows.click(findWindowsObject('Object Repository/Elemento(5)'))

Windows.click(findWindowsObject('Object Repository/Elemento(6)'))

Windows.click(findWindowsObject('Object Repository/Elemento(7)'))

Windows.click(findWindowsObject('Object Repository/Elemento(8)'))

Windows.click(findWindowsObject('Object Repository/Elemento(9)'))

Windows.click(findWindowsObject('Object Repository/Elemento(10)'))

Windows.closeApplication()

