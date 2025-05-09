public class Solution {
    public string solution(string phone_number) {
        int maskLength = phone_number.Length - 4;
        
        // new string('*', maskLength) 은 maskLength 길이의 *로 된 문자열 생성
        // phone_number.Substring(maskLength) 은 phone_number를 maskLength 부터 잘라낸 문자열
        string masked = new string('*', maskLength) + phone_number.Substring(maskLength);
        return masked;
    }
}