using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(string[] id_list, string[] report, int k)
    {
        // 1. 신고 기록을 정리하고, 신고당한 횟수를 집계합니다.
        // reportedCount: 피신고자 -> 신고당한 횟수
        Dictionary<string, int> reportedCount = new Dictionary<string, int>();
        // reporterList: 신고자 -> 피신고자 리스트
        Dictionary<string, List<string>> reporterList = new Dictionary<string, List<string>>();

        foreach (string id in id_list)
        {
            reportedCount[id] = 0;
            reporterList[id] = new List<string>();
        }

        foreach (string s in report.Distinct())
        {
            string[] parts = s.Split(' ');
            string reporter = parts[0];
            string reported = parts[1];

            reporterList[reporter].Add(reported);
            reportedCount[reported]++;
        }

        // 2. 정지 대상 유저를 식별합니다.
        // bannedUsers: k회 이상 신고당한 유저 목록 (HashSet으로 탐색 속도 최적화)
        HashSet<string> bannedUsers = new HashSet<string>();
        foreach (var count in reportedCount)
        {
            if (count.Value >= k)
            {
                bannedUsers.Add(count.Key);
            }
        }

        // 3. 신고자별로 받을 메일 수를 계산합니다.
        // answer: id_list 순서에 맞는 최종 결과
        int[] answer = new int[id_list.Length];
        for (int i = 0; i < id_list.Length; i++)
        {
            string reporter = id_list[i];
            int mailCount = 0;
            
            foreach (string reportedUser in reporterList[reporter])
            {
                if (bannedUsers.Contains(reportedUser))
                {
                    mailCount++;
                }
            }
            answer[i] = mailCount;
        }

        return answer;
    }
}