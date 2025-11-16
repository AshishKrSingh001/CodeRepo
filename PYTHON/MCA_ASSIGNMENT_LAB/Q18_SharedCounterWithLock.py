import threading

counter = 0
lock = threading.Lock()

def update():
    global counter
    for _ in range(100000):
        with lock:
            counter += 1

threads = [threading.Thread(target=update) for _ in range(5)]
for t in threads: t.start()
for t in threads: t.join()

print("Final counter value:", counter)
