using System.Data;

namespace SimpleCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        int firstNum = 0;       // 첫 번째 숫자 저장
        string selectedOp = ""; // 선택된 연산자 (+, -, *, /) 저장
        bool isNewNum = true;   // 새 숫자를 입력할 타이밍인지 확인


        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 1. 숫자 입력 (0-9)
            if (char.IsDigit(e.KeyChar))
            {
                // 숫자 버튼을 눌렀을 때와 동일한 함수 호출
                AddNumber(e.KeyChar.ToString());
                e.Handled = true;
            }
            // 2. 연산자 입력 (+, -, *, /, %)
            else if ("+-*/%".Contains(e.KeyChar))
            {
                // 연산자 버튼을 눌렀을 때와 동일한 함수 호출
                SetOperator(e.KeyChar.ToString());
                e.Handled = true;
            }
            // 3. 엔터키 (결과 계산) - KeyPress에서는 (char)13
            else if (e.KeyChar == (char)13)
            {
                CalculateResult();
                e.Handled = true;
            }
            // 4. 백스페이스 (지우기)
            else if (e.KeyChar == (char)Keys.Back)
            {
                btnBack_Click(sender, e);
                e.Handled = true;
            }
            // 5. ESC (초기화)
            else if (e.KeyChar == (char)27)
            {
                btnC_Click(sender, e);
                e.Handled = true;
            }
        }
        private void CalculateResult()
        {
            try
            {
                string formula = txtDisplay.Text;
                if (string.IsNullOrEmpty(formula) || formula.Contains("=")) return;

                // 특수문자만 컴퓨터용으로 바꿉니다. (%는 그대로 두면 됩니다)
                string computerFormula = formula.Replace("×", "*")
                                                .Replace("÷", "/");

                System.Data.DataTable dt = new System.Data.DataTable();
                var resultValue = dt.Compute(computerFormula, "");
                int result = Convert.ToInt32(resultValue);

                // 결과 표시 (예: 10 % 3 = 1)
                string fullEntry = $"{formula} = {result}";
                txtDisplay.Text = fullEntry;
                txtResult.Text = result.ToString();

                // 기록에 저장
                lstHistory.Items.Insert(0, fullEntry);
                isNewNum = true;
            }
            catch (Exception)
            {
                MessageBox.Show("수식이 올바르지 않습니다.");
            }
        }
        private void AddNumber(string num)
        {
            if (isNewNum || txtDisplay.Text == "0")
            {
                txtDisplay.Text = num;
                isNewNum = false;
            }
            else
            {
                if (txtDisplay.Text.Contains("=")) // 결과가 이미 나온 상태면 새로 시작
                {
                    txtDisplay.Text = num;
                }
                else
                {
                    txtDisplay.Text += num;
                }
            }
        }

        // 연산자 버튼 클릭 시 호출 (SetOperator)
        private void SetOperator(string op)
        {
            if (txtDisplay.Text.Contains("="))
            {
                txtDisplay.Text = txtResult.Text + " " + op + " ";
            }
            else
            {
                // "10 mod " 처럼 공백을 넣어줘야 나중에 계산할 때 편합니다.
                txtDisplay.Text += " " + op + " ";
            }
            isNewNum = false;
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            // 기존 텍스트박스 값 뒤에 "0"을 추가합니다.
            AddNumber("0");
        }
        private void btnNum1_Click(object sender, EventArgs e)
        {
            // 기존 텍스트박스 값 뒤에 "1"을 추가합니다.
            AddNumber("1");
        }
        private void btnNum2_Click(object sender, EventArgs e)
        {
            // 기존 텍스트박스 값 뒤에 "2을 추가합니다.
            AddNumber("2");
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            // 기존 텍스트박스 값 뒤에 "3"을 추가합니다.
            AddNumber("3");
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            // 기존 텍스트박스 값 뒤에 "4"을 추가합니다.
            AddNumber("4");
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            // 기존 텍스트박스 값 뒤에 "5"을 추가합니다.
            AddNumber("5");
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            // 기존 텍스트박스 값 뒤에 "6"을 추가합니다.
            AddNumber("6");
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            // 기존 텍스트박스 값 뒤에 "7"을 추가합니다.
            AddNumber("7");
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            // 기존 텍스트박스 값 뒤에 "8"을 추가합니다.
            AddNumber("8");
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            // 기존 텍스트박스 값 뒤에 "9"을 추가합니다.
            AddNumber("9");
        }

        private void btnOpPlus_Click(object sender, EventArgs e)
        {
            SetOperator("+");
        }

        private void btnOpMinus_Click(object sender, EventArgs e)
        {
            SetOperator("-");
        }

        private void btnOpTimes_Click(object sender, EventArgs e)
        {
            SetOperator("*");
        }

        private void btnOpDiv_Click(object sender, EventArgs e)
        {
            SetOperator("/");
        }
        // 중복되는 코드를 줄이기 위한 공통 함수
        /*private void SetOperator(string op)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                // 1. 현재 화면에 있는 숫자를 첫 번째 숫자로 저장
                // (이미 수식이 있는 상태라면 결과값을 firstNum으로 잡아야 함)
                firstNum = int.Parse(txtDisplay.Text);

                selectedOp = op;

                // 2. ★ 핵심: 화면 뒤에 " + "를 붙임
                txtDisplay.Text += " " + op + " ";

                // 3. 연산자 뒤에 숫자를 이어서 써야 하므로 false로 설정
                isNewNum = false;
            }
        } */

        private void btnOpEq_Click(object sender, EventArgs e)
        {
            CalculateResult();
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            // 1. 현재 입력창이 비어있거나 "0"이면 바꿀 필요가 없음
            if (string.IsNullOrEmpty(txtDisplay.Text) || txtDisplay.Text == "0")
            {
                return;
            }

            // 2. 현재 텍스트박스의 숫자를 정수로 변환
            if (int.TryParse(txtDisplay.Text, out int currentVal))
            {
                // 3. -1을 곱해서 부호 반전
                currentVal *= -1;

                // 4. 결과를 다시 텍스트박스에 표시
                txtDisplay.Text = currentVal.ToString();
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            // 1. 입력창과 결과창을 초기화합니다.
            txtDisplay.Text = "";
            txtResult.Text = "";       // 결과창은 비워줍니다.

            // 2. 메모리에 저장된 계산용 변수들을 초기화합니다.
            firstNum = 0;              // 저장된 첫 번째 숫자 초기화
            selectedOp = "";           // 선택된 연산자 초기화
            isNewNum = true;           // 다음 숫자를 누르면 "0"을 지우고 새로 써지도록 설정
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                // 끝에 공백이 있다면 연산자가 있는 것이므로 3글자(" + ")를 한 번에 지우는 게 편합니다.
                if (txtDisplay.Text.EndsWith(" "))
                {
                    txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 3);
                }
                else
                {
                    txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
                }
            }

            if (string.IsNullOrEmpty(txtDisplay.Text)) txtDisplay.Text = "0";
        }


        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalculateResult(); // 계산 실행
                isNewNum = true;

                // 엔터키가 다른 버튼을 누르는 것을 방지하고 이벤트를 여기서 종료함
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) //엔터키로 결과 실행
        {
            // 엔터 키가 눌렸을 때
            if (keyData == Keys.Enter)
            {
                CalculateResult(); // 계산 실행
                isNewNum = true;   // 다음 숫자를 위해 상태 업데이트
                return true;       // 이벤트를 여기서 처리했음을 알리고 종료 (중복 방지)
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void btnCE_Click(object sender, EventArgs e)
        {
            // 1. 공백을 기준으로 수식을 나눕니다.
            string[] parts = txtDisplay.Text.Split(' ');

            // 2. 수식이 "숫자 연산자 숫자" 형태라면 마지막 숫자만 지웁니다.
            if (parts.Length >= 3)
            {
                // "5 + 612" -> "5 + " 상태로 만듭니다.
                txtDisplay.Text = parts[0] + " " + parts[1] + " ";
            }
            else
            {
                // 3. 연산자 입력 전이거나 숫자만 있는 상태라면 전체를 "0"으로 초기화
                txtDisplay.Text = "0";
                isNewNum = true;
            }
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                // 현재 화면에 있는 값을 가져와서 제곱식 생성
                // 예: "5" -> "(5) * (5)",  "(1+2)" -> "(1+2) * (1+2)"
                string currentText = txtDisplay.Text;
                if (currentText.Contains("=")) currentText = txtResult.Text; // 결과값에서 이어할 경우

                string formula = $"({currentText}) * ({currentText})";

                // 계산 실행 및 기록 (CalculateResult와 유사한 로직)
                ExecuteSpecialCalc(formula, $"{currentText}²");
            }
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                string currentText = txtDisplay.Text;
                if (currentText.Contains("=")) currentText = txtResult.Text;

                try
                {
                    // 현재 수식의 최종 값을 먼저 구함
                    DataTable dt = new DataTable();
                    double val = Convert.ToDouble(dt.Compute(currentText.Replace("×", "*").Replace("÷", "/"), ""));

                    if (val < 0) { MessageBox.Show("음수는 루트를 구할 수 없습니다."); return; }

                    int result = (int)Math.Sqrt(val);
                    string fullEntry = $"√({currentText}) = {result}";

                    txtDisplay.Text = fullEntry;
                    txtResult.Text = result.ToString();
                    lstHistory.Items.Insert(0, fullEntry);
                    isNewNum = true;
                }
                catch { MessageBox.Show("수식이 올바르지 않습니다."); }
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            // 이제 "mod" 대신 "%"를 넘겨줍니다.
            SetOperator("%");
        }


        private void ExecuteSpecialCalc(string computerFormula, string displayLabel)
        {
            try
            {
                DataTable dt = new DataTable();
                object resultObj = dt.Compute(computerFormula, "");
                int result = Convert.ToInt32(resultObj);

                string fullEntry = $"{displayLabel} = {result}";

                txtDisplay.Text = fullEntry;
                txtResult.Text = result.ToString();
                lstHistory.Items.Insert(0, fullEntry); // 기록에 추가
                isNewNum = true;
            }
            catch
            {
                MessageBox.Show("계산 중 오류가 발생했습니다.");
            }
        }
        private void lstHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHistory.SelectedItem != null)
            {
                // 기록에서 "=" 뒤의 숫자(결과값)만 추출
                string selectedItem = lstHistory.SelectedItem.ToString();
                string resultValue = selectedItem.Split('=')[1].Trim();

                // 현재 입력창에 그 값을 넣어줌
                txtDisplay.Text = resultValue;
                isNewNum = true;
            }
        }

        private void btnClrHis_Click(object sender, EventArgs e)
        {
            lstHistory.Items.Clear(); // 모든 기록 삭제
        }

        private void btnOpenParen_Click(object sender, EventArgs e)
        {
            if (isNewNum || txtDisplay.Text == "0") txtDisplay.Text = "(";
            else txtDisplay.Text += "(";
            isNewNum = false;
        }
        private void btnCloseParen_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ")";
            isNewNum = false;
        }
    }
}
