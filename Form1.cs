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
                if (isNewNum)
                {
                    txtDisplay.Text = e.KeyChar.ToString();
                    isNewNum = false; // 이제 숫자를 이어 붙여야 함
                }
                else
                {
                    txtDisplay.Text += e.KeyChar;
                }
                e.Handled = true;
            }
            // 2. 연산자 입력 (+, -, *, /)
            else if ("+-*/".Contains(e.KeyChar))
            {
                firstNum = int.Parse(txtDisplay.Text); // 현재 숫자 저장
                selectedOp = e.KeyChar.ToString();    // 어떤 연산인지 저장
                isNewNum = true;                      // 다음 숫자는 새로 써야 함
                e.Handled = true;
            }
            // 3. 엔터키 (결과 계산)
            /*else if (e.KeyChar == (char)Keys.Enter)
            {
                CalculateResult();
                isNewNum = true;
                e.Handled = true;
            } */
            // 4. ESC키 (초기화 - Clear)
            else if (e.KeyChar == (char)27) // ESC 아스키 코드
            {
                txtDisplay.Text = "0";
                firstNum = 0;
                selectedOp = "";
                isNewNum = true;
                e.Handled = true;
            }
            else if ("+-*/".Contains(e.KeyChar))
            {
                // 숫자가 입력된 상태에서만 연산자를 받도록 설정
                if (!isNewNum)
                {
                    firstNum = int.Parse(txtDisplay.Text);
                    isNewNum = true;
                }

                // 어떤 상황이든 마지막에 누른 연산자로 업데이트!
                selectedOp = e.KeyChar.ToString();

                // (선택 사항) 현재 어떤 연산자가 선택됐는지 라벨 등에 표시하면 더 친절합니다.
                // lblOperator.Text = selectedOp; 

                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Back) //백스페이스 입력
            {
                // 위에 만든 마우스 클릭 함수를 그대로 호출
                btnBack_Click(sender, e);

                // 텍스트박스에 기본 백스페이스 동작이 중복으로 일어나지 않게 막음
                e.Handled = true;
            }
        }
        private void CalculateResult()
        {
            try
            {
                // txtDisplay에 숫자가 아닌 것이 들어있으면 여기서 에러가 날 수 있음
                int secondNum = int.Parse(txtDisplay.Text);
                int result = 0;

                switch (selectedOp)
                {
                    case "+": result = firstNum + secondNum; break;
                    case "-": result = firstNum - secondNum; break;
                    case "*": result = firstNum * secondNum; break;
                    case "/":
                        if (secondNum != 0) result = firstNum / secondNum;
                        else { MessageBox.Show("0으로 나눌 수 없습니다."); return; }
                        break;
                }

                txtResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("숫자 입력이 올바르지 않습니다: " + ex.Message);
            }
        }
        private void AddNumber(string num)
        {
            // 만약 연산자를 누른 직후라면? 기존 글자를 지우고 새로 시작!
            if (isNewNum)
            {
                txtDisplay.Text = num;
                isNewNum = false; // 이제 숫자를 새로 시작했으니 다음 숫자는 뒤에 붙여야 함
            }
            else
            {
                // 평소에는 기존 숫자 뒤에 이어 붙임
                // (단, 처음 숫자가 "0"이면 지우고 시작하는 게 좋음)
                if (txtDisplay.Text == "0") txtDisplay.Text = num;
                else txtDisplay.Text += num;
            }
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
        private void SetOperator(string op)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                firstNum = int.Parse(txtDisplay.Text); // 현재 숫자를 저장
                selectedOp = op;                      // 연산자 저장
                isNewNum = true;                      // 다음 숫자를 위해 화면 비우기 예고

            }
        }

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
            // 지울 글자가 있는지 확인
            if (txtDisplay.Text.Length > 0)
            {
                // 마지막 한 글자를 제외하고 나머지만 다시 저장
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }

            // 만약 다 지워서 빈칸이 되면 "0"으로 표시하고 새로운 숫자를 받을 준비를 함
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
                isNewNum = true;
            }
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
            //CE버튼 입력시 현재 입력창만 초기화하고 계산에 필요한 변수들은 유지
            txtDisplay.Text = "0";
            isNewNum = true;
        }
    }
}
