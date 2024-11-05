class Solution {
    public String solution(String n_str) {
        //앞부분에 해당하는 문자열을 뒷부분의 문자열로 교체하는 메서드
        String answer = n_str.replaceFirst("^0+", "");
        // ^ : 시작부분부터 | 0+ : 연속된 하나 이상의 0을 > "" : 빈 문자열로 교체 (삭제)
        return answer;
    }
}